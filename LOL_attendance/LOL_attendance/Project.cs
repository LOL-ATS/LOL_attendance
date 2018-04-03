using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace LOL_attendance
{
    //Liana: class to handle project entity
    class Project
    {
        string connStr = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        //Get project name by project id
        public string GetNameByID(int projectID)
            {
                string result = "";
                conn = new SqlConnection(connStr);
                cmd = new SqlCommand("SELECT name FROM project WHERE id =" + projectID, conn);

                conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();
                    result = rdr.GetString(0);
                }

                conn.Close();
                return result;
            }

        //Define project ID by name
        public int GetIDByName(string name)
        {
            int projectID = 0;
            if (name != "")
            {
                conn = new SqlConnection(connStr);
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

        //check if project with defined name already exists
        public bool IsExisting(string name)
        {
            bool projectExists = true;
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


    }
}
