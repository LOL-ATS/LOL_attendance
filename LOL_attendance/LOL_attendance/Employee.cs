using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace LOL_attendance
{
    //Liana: class to handle employee entity
    class Employee
    {
        string connStr = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;

        public string GetSurnameByID(int employeeID)
        {
            string surname = "";
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand("SELECT surname FROM employee WHERE id =" + employeeID, conn);

            conn.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                surname = rdr.GetString(0);
            }

            conn.Close();
            return surname;
        }

        //Liana:
        //Check if login field is unique
        public bool IsExistingByLogin(string userLogin)
        {
            bool userExists = true;
            conn = new SqlConnection(connStr);
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

        //Liana: 
        //define employee ID by login
        public int GetIDByLogin(string login)
        {
            int employee_id = 0;
            conn = new SqlConnection(connStr);
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

        //Lana & Liana: 
        //define employee id by role and surname 
        public int GetIDByRoleAndSurname(string employee_role, string employee_surname)
        {
            int employee_id = 0;
            if (employee_role != "" & employee_surname != "")
            {
                conn = new SqlConnection(connStr);
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
        //Liana: update Saved or Rejected Timerecord
        public int UpdateSavedOrRejected(string date, string hours, int employeeID, int siteID)
            {
                int result = 0;
                SqlConnection conn;
                SqlCommand cmd;
                conn = new SqlConnection(connStr);
                cmd = new SqlCommand("UPDATE timesheet SET hours = @hours, status='Saved'  where date = @date and employee_id = @employee_id and site_id = @site_id", conn);

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
