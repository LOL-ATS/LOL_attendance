using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace LOL_attendance
{
    // A class for keeping the state of login of users 
    public class userClass
    {
        public enum userRoles
        {
                Worker = 4,
                Admin = 1,
                SiteManager = 3,
                ProjectManager = 2,
        }

        public string userName { get; set; }
        //the time of login
        public DateTime userDOB{ get; set; }
        public userRoles userRole { get; set; }
        public string userfullname { get; set; }
        public int userID { get; set; }

    }
}
