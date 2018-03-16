﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOL_attendance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static userClass usr = new userClass();

        [STAThread]
        static void Main()
        {
            usr.userRole = userClass.userRoles.Worker;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(usr));
        }
    }
}
