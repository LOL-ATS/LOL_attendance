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
        DataTable dtTimesheet = new DataTable();

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
            dtWorkers.Columns.Add("ID", typeof(Int32));
            dtWorkers.Columns.Add("Name", typeof(String));
            dtWorkers.Columns.Add("Surname", typeof(String));
            dtTimesheet.Columns.Add("Status", typeof(String));

        }

        private void frmTimesheet_Load(object sender, EventArgs e)
        {
            Main frm = (Main)this.MdiParent;
            this.Text = "Timesheet: " + frm.User.userfullname.ToString() + " (" + frm.User.userRole.ToString() + ")";

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
            int totalRows = 0;
            totalRows = dataGridViewTS.RowCount;
            int tickedRows = 0;
            int updatedRows = 0;
            //if there is no rows in TS show message NO rows in TS
            if (totalRows == tickedRows)
            {
                MessageBox.Show("No data to save");
            }
            else
            {
                for (int i = dataGridViewTS.Rows.Count - 1; i >= 0; i--)
                {
                    //if row is ticked proceed and tickedRow++
                    if ((bool)dataGridViewTS.Rows[i].Cells[0].FormattedValue)
                    {
                        tickedRows++;
                        //if row status is null create new TS records with status Saved
                        if (dataGridViewTS.Rows[i].Cells[5].Value.ToString() == "")
                        {
                            TS TSRecord = new TS();
                            int returnValue =
                            TSRecord.Add(dateTimePicker.Value.ToString("yyyy-MM-dd"), TimeSpan.Parse(dataGridViewTS.Rows[i].Cells[4].Value.ToString()).ToString(), Convert.ToInt32(dataGridViewTS.Rows[i].Cells[1].Value.ToString()), currentSiteID);
                            if (returnValue == 1) updatedRows++;
                        }
                        else if (dataGridViewTS.Rows[i].Cells[5].Value.ToString() == "Saved")
                        {
                            TS TSRecord = new TS();
                            int returnValue =
                            TSRecord.UpdateSaved(dateTimePicker.Value.ToString("yyyy-MM-dd"), TimeSpan.Parse(dataGridViewTS.Rows[i].Cells[4].Value.ToString()).ToString(), Convert.ToInt32(dataGridViewTS.Rows[i].Cells[1].Value.ToString()), currentSiteID);
                            if (returnValue == 1) updatedRows++;
                        }
                        else
                        {
                            //lines with status Rejected, Approved By SM, Approved By PM are not updated
                        }
                    }
                    else
                    {
                    }
                }
                MessageBox.Show(updatedRows.ToString() + " updated");
                Updatedata();
            }
         }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            conn = new SqlConnection(connStr);
            Main frm = (Main)this.MdiParent;

            //Check Role of User
            string TSstatus = "";
            Int32 ApproverID = 0;

            if (frm.User.userRole == userClass.userRoles.SiteManager)
            {
                //-----------------Site Manager -------------------
                TSstatus = "Approved By SM";
                ApproverID = currentSiteManagerID;

            }
            else if (frm.User.userRole == userClass.userRoles.ProjectManager)
            {
                //-----------------Project Manager -------------------
                TSstatus = "Approved By PM";
                ApproverID = currentProjectManagerID;
            } else
            {
                TSstatus = "";
            }
            int approveRows = 0;
            int NoapprovededRows = 0;
            if (dataGridViewTS.Rows.Count == 0)
            {
                MessageBox.Show("No Records for approving");

            }
            else
            {
                /*Omid:commented becuse current site id implimented as public variable
                
                //define selected Site ID
                conn = new SqlConnection(connStr);
                cmd = new SqlCommand("SELECT id from site where isActive='True and name='" + comboBoxSitename.SelectedItem + "'", conn);
                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    currentSiteID = rdr.GetInt32(0);
                }
                conn.Close();*/

                for (int i = dataGridViewTS.Rows.Count - 1; i >= 0; i--)
                {
                    if (((bool)dataGridViewTS.Rows[i].Cells[0].FormattedValue) && (dataGridViewTS.Rows[i].Cells[5].Value.ToString() != "Approved By PM"))
                    {
                        if (dataGridViewTS.Rows[i].Cells[5].Value.ToString() == "" && frm.User.userRole==userClass.userRoles.SiteManager)
                        {
                            cmd = new SqlCommand("INSERT into timesheet(date, hours, employee_id, site_id, status,approved_by_id) VALUES(@date, @hours, @employee_id, @site_id, @status,@approverid)", conn);
                            cmd.Parameters.AddWithValue("@date", dateTimePicker.Value.ToString("yyyy-MM-dd"));

                            cmd.Parameters.AddWithValue("@hours", TimeSpan.Parse(dataGridViewTS.Rows[i].Cells[4].Value.ToString()));
                            cmd.Parameters.AddWithValue("@employee_id", Convert.ToInt32(dataGridViewTS.Rows[i].Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@site_id", currentSiteID);
                            cmd.Parameters.AddWithValue("@status", TSstatus);
                            cmd.Parameters.AddWithValue("@approverid", ApproverID);

                            
                            
                            conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                approveRows++;
                            }
                            conn.Close();
                        }
                        else if ((dataGridViewTS.Rows[i].Cells[5].Value.ToString() == "Saved" && frm.User.userRole == userClass.userRoles.SiteManager) || (dataGridViewTS.Rows[i].Cells[5].Value.ToString() == "Approved By SM" && frm.User.userRole == userClass.userRoles.ProjectManager))
                        {
                           cmd = new SqlCommand("UPDATE timesheet set hours = @hours, status = @status, approved_by_id =@approverid where employee_id= @employee_id and site_id = @site_id and date= @date", conn);
                            cmd.Parameters.AddWithValue("@status", TSstatus);

                            cmd.Parameters.AddWithValue("@hours", TimeSpan.Parse(dataGridViewTS.Rows[i].Cells[4].Value.ToString()));
                            cmd.Parameters.AddWithValue("@approverid", ApproverID);
                            cmd.Parameters.AddWithValue("@employee_id", Convert.ToInt32(dataGridViewTS.Rows[i].Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@site_id", currentSiteID);
                            cmd.Parameters.AddWithValue("@date", dateTimePicker.Value.ToString("yyyy-MM-dd"));

                            conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                approveRows++;
                            }
                            conn.Close();
                        }
                        else { NoapprovededRows++; }

                    }
                }
                if (frm.User.userRole == userClass.userRoles.SiteManager)
                {
                    if (NoapprovededRows>0) MessageBox.Show(String.Format("The {0} records is not approved ", approveRows));
                }
                else
                {
                    if (NoapprovededRows > 0) MessageBox.Show(String.Format("{0} records need Site manager approval", NoapprovededRows));
                    
                }
               
            }
            if (approveRows > 0) Updatedata();
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

            Main frm = (Main)this.MdiParent;



            if (frm.User.userRole == userClass.userRoles.ProjectManager)
            {
                cmd = new SqlCommand("SELECT employee_id as ID, name, surname, hours, status FROM employee e, timesheet ts where e.id=ts.employee_id and date ='" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "' and site_id = @site_id and ( ts.status = 'Approved By SM' or ts.status = 'Approved By PM' or ts.status='Rejected')", conn);
            }
            else
            {
                cmd = new SqlCommand("SELECT employee_id as ID, name, surname, hours, status FROM employee e, timesheet ts where e.id=ts.employee_id and date ='" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "' and site_id = @site_id", conn);
            }
            

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
            //Omid:commented As Lana ask me 
            //if (frm.User.userRole == userClass.userRoles.ProjectManager && dataGridViewTS.Rows.Count == 0) MessageBox.Show("There is no Timesheet created for this site yet!");
            //----------------------------------------------------

        }
        //add lines in TS for selected workers
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //Liana: add lines in TS for selected workers in for cycle for each checked worker
            // delete worker line in worker list
            if (dataGridViewEmploye.Rows.Count == 0)
            {
                MessageBox.Show("There is no more employee for creating TS");
            }
            else
            {
                for (int i = dataGridViewEmploye.Rows.Count - 1; i >= 0; i--)
                {
                    //check if worker selected
                    if ((bool)dataGridViewEmploye.Rows[i].Cells[0].FormattedValue)
                    {
                        //create line in TS for selected worker
                        DataRow workRow = dtTimesheet.NewRow();
                        workRow[0] = (int)dataGridViewEmploye.Rows[i].Cells[1].Value;
                        workRow[1] = dataGridViewEmploye.Rows[i].Cells[2].Value.ToString();
                        workRow[2] = dataGridViewEmploye.Rows[i].Cells[3].Value.ToString();
                        workRow[3] = TimeSpan.Parse("00:00");
                        dtTimesheet.Rows.Add(workRow);
                        dataGridViewTS.DataSource = dtTimesheet;
                        //remove worker from list of workers
                        dataGridViewEmploye.Rows.RemoveAt(i);
                    }
                }
                /*Liana: commented because works incorrectly
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
                */
            }
        }

        private void btnDelEmployee_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            conn = new SqlConnection(connStr);
            if (dataGridViewTS.Rows.Count == 0)
            {
                MessageBox.Show("There’s nothing to delete");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Selected records will be DELETE from this Timesheet except approved by Project Manager records", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Liana: delete rows from TS and add rows to workers list
                    for (int i = dataGridViewTS.Rows.Count - 1; i >= 0; i--)
                    {
                        //delete only checked rows in state not Approved by PM
                        if (((bool)dataGridViewTS.Rows[i].Cells[0].FormattedValue) && dataGridViewTS.Rows[i].Cells[4].ToString() != "Approved by PM")
                        {
                            //first add worker to worker list
                            DataRow workRow = dtWorkers.NewRow();
                            workRow[0] = (int)dataGridViewTS.Rows[i].Cells[1].Value;
                            workRow[1] = dataGridViewTS.Rows[i].Cells[2].Value.ToString();
                            workRow[2] = dataGridViewTS.Rows[i].Cells[3].Value.ToString();
                            dtWorkers.Rows.Add(workRow);
                            dataGridViewEmploye.DataSource = dtWorkers;
                            //delete TS from db 
                            cmd = new SqlCommand("DELETE FROM timesheet WHERE employee_id=" + dataGridViewTS.Rows[i].Cells[1].Value.ToString() + " and date ='" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "' and site_id =" + currentSiteID.ToString(), conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            //delete TS from dataGridView TS
                            dataGridViewTS.Rows.RemoveAt(i);
                        }
                    }
                    /*Liana: commented because works incorrectly
                    foreach (DataGridViewRow row in dataGridViewTS.Rows)
                    {   
                        Boolean chk = Convert.ToBoolean(row.Cells[0].Value);

                        if (chk == true && row.Cells[4].ToString() != "Approved by PM")
                        {
                            cmd = new SqlCommand("DELETE FROM timesheet WHERE employee_id=" + row.Cells[1].Value.ToString() + " and date ='" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "' and site_id =" + currentSiteID.ToString(), conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            dtTimesheet.Rows.RemoveAt(currentRow);
                            dataGridViewTS.DataSource = dtTimesheet;
                        }
                    }*/
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
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
                    btnReject.Enabled = false;
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
                   // btnAddEmployee.Enabled = true;
                    //btnDelEmployee.Enabled = true;
                    //btnSave.Enabled = true;
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
                    //btnAddEmployee.Enabled = false;
                    //btnDelEmployee.Enabled = false;
                    //btnSave.Enabled = false;
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

        private void frmTimesheet_Shown(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataReader rdr;
            conn = new SqlConnection(connStr);
            Main frm = (Main)this.MdiParent;

            //Check Role of User


            if (frm.User.userRole == userClass.userRoles.SiteManager)
            {
                //-----------------Site Manager -------------------
                currentSiteManagerID = frm.User.userID;

                //*****bind Project dropdown with values from db*****
                //Liana: Fixed query for isActive flag
                cmd = new SqlCommand("SELECT DISTINCT id, name FROM project p JOIN(select distinct proj_id, mngr_id, isActive from site )s ON p.id = s.proj_id WHERE s.mngr_id = " + currentSiteManagerID.ToString() + " and p.isActive = 'True' and s.isActive = 'True'", conn);
                btnReject.Enabled = false;

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
                btnSave.Enabled = false;
                btnAddEmployee.Enabled = false;
                btnDelEmployee.Enabled = false;

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
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
                SqlConnection conn;
                SqlCommand cmd;
                conn = new SqlConnection(connStr);
                Main frm = (Main)this.MdiParent;

                //Check Role of User
                string TSstatus = "";
                Int32 ApproverID = 0;

                if (frm.User.userRole == userClass.userRoles.ProjectManager)
                {
                    //-----------------Project Manager -------------------
                    TSstatus = "Rejected";
                    ApproverID = currentProjectManagerID;
                }
                int rejectedRows = 0;

                if (dataGridViewTS.Rows.Count == 0)
                {
                    MessageBox.Show("No Records for rejecting");
                }
                else
                {

                    for (int i = dataGridViewTS.Rows.Count - 1; i >= 0; i--)
                    {
                        if (((bool)dataGridViewTS.Rows[i].Cells[0].FormattedValue) && (dataGridViewTS.Rows[i].Cells[5].Value.ToString() == "Approved By PM") || (dataGridViewTS.Rows[i].Cells[5].Value.ToString() == "Approved By SM"))
                        {
                            cmd = new SqlCommand("UPDATE timesheet set status = @status where employee_id= @employee_id and site_id = @site_id and date= @date", conn);
                            cmd.Parameters.AddWithValue("@status", TSstatus);
                            cmd.Parameters.AddWithValue("@employee_id", Convert.ToInt32(dataGridViewTS.Rows[i].Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@site_id", currentSiteID);
                            cmd.Parameters.AddWithValue("@date", dateTimePicker.Value.ToString("yyyy-MM-dd"));

                            conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                rejectedRows++;
                            }
                            conn.Close();
                        }
                        else { }

                    }

                }
                if (rejectedRows > 0) Updatedata();
            }
        
    }
}
