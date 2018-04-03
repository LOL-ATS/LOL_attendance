using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace LOL_attendance
{
    //Liana: class to handle role entity
    class Role
    {
        string connStr = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;

        //Liana: 
        //define role ID by role name
        public int GetIDByName(string roleName)
        {
            int roleID;

            //define role_id by role_name from db
            conn = new SqlConnection(connStr);
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

    }
}
