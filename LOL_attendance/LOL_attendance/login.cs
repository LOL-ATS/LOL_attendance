using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add by omid
using System.Data.SqlClient;
using System.Configuration;

namespace LOL_attendance
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            userClass loginuser=new userClass();
            string connStr = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
            using (var con = new SqlConnection(connStr))
            {
                //check username and password
                SqlCommand cmd = new SqlCommand("select id, name, surname, role_id from employee where [role_id]<>'' and [login]=@username and [password]=@password ", con);

                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Connection.Open();
            
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();


                if (rdr.HasRows)
                {
                    //user password is rigt so show controls 
                    Main frm = (Main)this.MdiParent;
                    //store username and the time of login in loginuser
                    loginuser.userDOB = DateTime.Now;
                    loginuser.userName = txtUsername.Text;
                    loginuser.userfullname = rdr["name"].ToString() + " " + rdr["surname"].ToString();
                    loginuser.userID = (int)rdr["id"];
                    Panel pnl = (Panel)frm.Controls["pnlMainBtn"];
                    pnl.Visible = true;
                    StatusStrip SS = (StatusStrip)frm.Controls["StatusStrip1"];
                    SS.Items["tSSLUsername"].Text = txtUsername.Text;
                    SS.Enabled = true;
                    //findout the role of  user and store in loginuser obj and enable right buttons

                    switch ((int)rdr["role_id"])
                        {
                            case 1:
                                loginuser.userRole = userClass.userRoles.Admin;
                                pnl.Controls["btnReg"].Enabled = Enabled;
                                pnl.Controls["btnTimesheet"].Enabled = Enabled;

                            break;
                            case 3:
                                loginuser.userRole = userClass.userRoles.SiteManager;
                                pnl.Controls["btnReg"].Enabled = false;
                                pnl.Controls["btnTimesheet"].Enabled = Enabled;

                            break;
                            case 2:
                                loginuser.userRole = userClass.userRoles.ProjectManager;
                                pnl.Controls["btnTimesheet"].Enabled = Enabled;
                                pnl.Controls["btnReg"].Enabled = false;

                            break;
                            default:
                                loginuser.userRole = userClass.userRoles.Worker;
                                pnl.Controls["btnTimesheet"].Enabled = false;
                                pnl.Controls["btnReg"].Enabled = false;
                            break;

                        }
                       
                        frm.setlogin(loginuser);                  
                        
                       
                        this.Hide();
                    }
                
                else                
                {
                    //Do to deal with failure……
                    MessageBox.Show("Username or password is wrong!");
                }
                cmd.Connection.Close();

            }
        }
        private void login_Load(object sender, EventArgs e)
        {
            Left = (MdiParent.ClientRectangle.Width - Width) / 2;
            Top = (MdiParent.ClientRectangle.Height - Height) / 2;
        }
    }
}
