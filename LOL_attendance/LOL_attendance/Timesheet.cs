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
        string connStr = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        
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
            comboBoxSitemngr.SelectedIndex = 0;
            
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
            comboBoxSitename.SelectedIndex = 0;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmTimesheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOLDBDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.lOLDBDataSet.employee);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int rows=0;
            rows = dataGridViewTS.RowCount;

            //define selected Site ID
            int currentSiteID = 0;
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("SELECT id from site where name='" + comboBoxSitename.SelectedItem+"'", conn);            
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
            //saving TS rows in db
            int rowIndex = 0;
            int addedRows = 0;
            while (rows > 0)
            {
                rows=rows-1;
                if (dataGridViewTS.Rows[rowIndex].Cells[1].Value != null)
                {
                    cmd = new SqlCommand("INSERT into timesheet (date, hours, employee_id, site_id, status) VALUES (@date, @hours, @employee_id, @site_id, 'Saved')", conn);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@hours", TimeSpan.FromHours(Convert.ToDouble(dataGridViewTS.Rows[rowIndex].Cells[2].Value.ToString())));
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
            }

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            int rows = 0;
            rows = dataGridViewTS.RowCount;

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
                lblTSStatus.Text = "Saved"+ Convert.ToString(updatedRows);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int rows = 0;
            rows = dataGridViewTS.RowCount;
            
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

            //search TS by date, manager_id and site
            cmd = new SqlCommand("SELECT name, employee_id, hours FROM employee e, timesheet ts where e.id=ts.employee_id and date ='" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "' and site_id = @site_id", conn);
            //cmd.Parameters.AddWithValue("@date", dateTimePicker.Value);
            //cmd.Parameters.AddWithValue("@hours", TimeSpan.FromHours(Convert.ToDouble(dataGridViewTS.Rows[rowIndex].Cells[2].Value.ToString())));
            //++need to add check for not null value 
            //cmd.Parameters.AddWithValue("@employee_id", Convert.ToInt32(dataGridViewTS.Rows[rowIndex].Cells[1].Value.ToString()));
            cmd.Parameters.AddWithValue("@site_id", currentSiteID);
            DataTable dt = new DataTable();
            conn.Open();
            rdr = cmd.ExecuteReader();
            int currentRow = 0;
            //DataGridViewRow row = new DataGridViewRow();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    //dt.Load(rdr);
                    /*    string val0=dt.Rows[0].ItemArray[0].ToString();
                    string val1 = dt.Rows[0].ItemArray[1].ToString();
                    string val2 = dt.Rows[1].ItemArray[0].ToString();*/
                    DataGridViewRow row = new DataGridViewRow();

                    //row.Cells["clmnEmployeeName"].Value = rdr[0].ToString();
                    //row.Cells[1].Value = rdr[1].ToString();
                    //row.Cells[2].Value = rdr[2].ToString();
                    
                    dataGridViewTS.Rows[currentRow].Cells["clmnEmployeeName"].Value =
                    rdr[0].ToString();
                    dataGridViewTS.Rows[currentRow].Cells["clmnEmployeeId"].Value =rdr[1].ToString();
                    dataGridViewTS.Rows[currentRow].Cells["clmnWorkingHours"].Value =rdr[2].ToString();
                    //currentRow++;
                    dataGridViewTS.Rows.Add(row);
                }
            }
            conn.Close();

            /*int rowIndex = 0;
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
            }*/

        }
    }
}
