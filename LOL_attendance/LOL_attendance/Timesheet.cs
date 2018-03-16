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
        DataTable dtTimesheet= new DataTable();
        DataTable dtWorkers = new DataTable();

        int currentSiteID = 0;
        int currentSiteManagerID = 0;

        SqlConnection conn;
        SqlCommand cmd;
        string connStr = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

        SqlDataReader rdr;

        public frmTimesheet()
        {
            InitializeComponent();
            conn = new SqlConnection(connStr);

            // Worker list
            cmd = new SqlCommand("SELECT e.id, name, surname FROM employee e WHERE e.role_id=4", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();


            if (rdr.HasRows)
            {
                dt.Load(rdr);
                dataGridViewEmploye.DataSource = dt;
            }
            conn.Close();

            //*/

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void frmTimesheet_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
           // dataGridViewTS.Columns[3].DefaultCellStyle.Format = "hh:mm";
            Main frm = (Main)this.MdiParent;
            if (frm.User.userRole == userClass.userRoles.SiteManager)
            {
                //bind Site dropdown with values from db
                comboBoxSitemngr.Items.Add(frm.User.userfullname);
                comboBoxSitemngr.SelectedIndex = 0;
                cmd = new SqlCommand("SELECT name FROM site where mngr_id=@mngr_id", conn);
                cmd.Parameters.AddWithValue("@mngr_id", frm.User.userID);

                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        comboBoxSitename.Items.Add(rdr.GetString(0));
                    }
                    comboBoxSitename.SelectedIndex = 0;
                }
                conn.Close();


            }
            else if (frm.User.userRole == userClass.userRoles.ProjectManager)
            {
                //bind Site Manager dropdown with values from db

                cmd = new SqlCommand("SELECT e.name FROM employee e, role r WHERE e.role_id=r.id and r.name='Site Manager'", conn);

                conn.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        comboBoxSitemngr.Items.Add(rdr.GetString(0));
                    }
                    comboBoxSitemngr.SelectedIndex = 0;
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
                    comboBoxSitename.SelectedIndex = 0;
                }
                conn.Close();



            }
            else if (frm.User.userRole == userClass.userRoles.Admin)
            {

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
            cmd = new SqlCommand("SELECT id from employee where name='" + comboBoxSitemngr.SelectedItem + "'", conn);

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

            //define selected Site ID
            int currentSiteID = 0;
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
            int currentSiteManagerID = 0;
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("SELECT id from employee where name='" + comboBoxSitemngr.SelectedItem + "'", conn);

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
                    cmd = new SqlCommand("UPDATE timesheet SET status = 'Approved', approved_by_id = " + currentSiteManagerID + "where date = " + dateTimePicker.Value + "and employee_id = @employee_id and site_id = @site_id", conn);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
        
        }



 

        private void Updatedata()
        {


            cmd.CommandText = "SELECT e.id, name, surname FROM employee e WHERE e.role_id=4";
            conn = new SqlConnection(connStr);
            cmd.Connection = conn;
            conn.Open();
            rdr = cmd.ExecuteReader();
            dtWorkers.Rows.Clear();
            if (rdr.HasRows)
            {        
                dtWorkers.Load(rdr);
                dataGridViewEmploye.DataSource = dtWorkers;
            }
            conn.Close();

            //Get selected Site ID
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
            //Get the selected Site Manager ID
            int currentSiteManagerID = 0;
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("SELECT id from employee where name='" + comboBoxSitemngr.SelectedItem + "'", conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                currentSiteManagerID = rdr.GetInt32(0);
            }
            conn.Close();

            //Search TS by date, manager_id and site
            cmd = new SqlCommand("SELECT employee_id , name, surname, hours, status FROM employee e, timesheet ts where e.id=ts.employee_id and date ='" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "' and site_id = @site_id", conn);

            cmd.Parameters.AddWithValue("@site_id", currentSiteID);
            //Fill the Timesheet GrideView
            conn.Open();
            rdr = cmd.ExecuteReader();
            dtTimesheet.Rows.Clear();
            if (rdr.HasRows)
            {
                dtTimesheet.Load(rdr);
                dataGridViewTS.DataSource = dtTimesheet;
              

            }
            conn.Close();
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


            DialogResult dialogResult = MessageBox.Show("Selected records will be DELETE from this Timesheet", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewTS.Rows)
                {
                    
                    Boolean chk = Convert.ToBoolean(row.Cells[0].Value);
                    DataTable dt = new DataTable();
                    if (chk)
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

        private void comboBoxSitename_SelectedValueChanged(object sender, EventArgs e)
        {
            Updatedata();
        }

        private void comboBoxSitemngr_SelectedValueChanged(object sender, EventArgs e)
        {
            Updatedata();
        }
    }
}
