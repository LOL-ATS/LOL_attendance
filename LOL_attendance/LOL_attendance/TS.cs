using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace LOL_attendance
{
    class TS
    {
        string connStr = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

        public int Add(string date, string hours, int employeeID, int siteID)
        {
            int result=0;
            SqlConnection conn;
            SqlCommand cmd;
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("INSERT into timesheet (date, hours, employee_id, site_id, status) VALUES (@date, @hours, @employee_id, @site_id,'Saved')", conn);
            cmd.Parameters.AddWithValue("@date", date);

            cmd.Parameters.AddWithValue("@hours", hours);

            cmd.Parameters.AddWithValue("@employee_id", employeeID);
            cmd.Parameters.AddWithValue("@site_id", siteID);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                result = 1;

            }
            else
            {
                result = 0;
            }
            conn.Close();

            return result;
        }
        public int UpdateSaved(string date, string hours, int employeeID, int siteID)
        {
            int result = 0;
            SqlConnection conn;
            SqlCommand cmd;
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("INSERT into timesheet (date, hours, employee_id, site_id, status) VALUES (@date, @hours, @employee_id, @site_id,'Saved')", conn);
            cmd = new SqlCommand("UPDATE timesheet SET hours = @hours where date = @date and employee_id = @employee_id and site_id = @site_id", conn);

            cmd.Parameters.AddWithValue("@date", date);

            cmd.Parameters.AddWithValue("@hours", hours);

            cmd.Parameters.AddWithValue("@employee_id", employeeID);
            cmd.Parameters.AddWithValue("@site_id", siteID);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                result = 1;

            }
            else
            {
                result = 0;
            }
            conn.Close();

            return result;
        }

    }
}
