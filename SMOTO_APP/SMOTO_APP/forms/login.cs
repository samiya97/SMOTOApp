using SMOTO_APP.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMOTO_APP
{
    public partial class login : Form
    {
        SqlConnection cnn = new SqlConnection("Data Source=Samiyabatool;Initial Catalog=SMOTO_APP;Persist Security Info=True;User ID=samiya;Password=tirmazi1234");
        SqlCommand cmd = new SqlCommand();
        public static string msgrtn;
        Regex namechk = new Regex(@"^[A-Z][a-zA-Z]*$");
        Regex emailchk = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    
        public login()
        {
            InitializeComponent();
        }
   

        private void signin_panelbtn_Click(object sender, EventArgs e)
        {
            //left 489
            signin_panel.Visible = true;
            signup_panel.Visible = false;
            signin_panel.Location = new Point(43, 76);
            //signin_panel.Refresh();
            bunifuSeparator1.Left = signin_panelbtn.Left;
            bunifuSeparator1.Width = signin_panelbtn.Width;
            // code for panel change //
        }

        private void signup_panelbtn_Click(object sender, EventArgs e)
        {
            signup_panel.Visible = true;
            signin_panel.Visible = false;
            signin_panel.Location = new Point(43, 76);
            //signin_panel.Refresh();
            bunifuSeparator1.Left = signup_panelbtn.Left;
            bunifuSeparator1.Width = signup_panelbtn.Width;
            //code for panel change //
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void singup_btn_Click(object sender, EventArgs e)
        {
           
            //code for datastoring and validation
           
            if (name_txt.Text == "") {
                namelbl.Text = "fill the feild";
            }
            else
            {
                namelbl.Text = "";
            }
            if (email_txt.Text == "")
            {
                emaillbl.Text = "fill the feild";
            }
            else
            {
                emaillbl.Text = "";
            }
            if (pass_txt.Text == "") {
                passlbl.Text = "fill the feild";
            }
            else
            {
                passlbl.Text = "";
            }


            if (!(name_txt.Text == "") && !namechk.Match(name_txt.Text).Success)
            {


                namelbl.Text = "Invalid name";
                

            }
            if(!(email_txt.Text == "") && !emailchk.Match(email_txt.Text).Success){
                emaillbl.Text = "Invalid email";
            }
            if ((namechk.Match(name_txt.Text).Success) && (emailchk.Match(email_txt.Text).Success))
            {
                SqlCommand cmd1 = new SqlCommand();
                    namelbl.Text = "";
                    emaillbl.Text = "";
                    cnn.Open();
                    cmd.CommandText = ("select 1 from app_users where email='" + email_txt.Text + "'");
                    cmd.Connection = cnn;
                    SqlDataReader rd = cmd.ExecuteReader();

                    if (!(rd.HasRows))
                    {
                       
                        cmd1.CommandText = "insert into app_users values('" + name_txt.Text + "', '" + email_txt.Text + "', '" + pass_txt.Text + "')";
                        rd.Close();
                        cmd1.Connection = cnn;
                        cmd1.ExecuteNonQuery();
                        msgrtn = "Registered successfully";
                        messagebox msgbox1 = new messagebox();
                        msgbox1.labelmsg(msgrtn);
                        msgbox1.Show();
                    }
                    else
                    {
                        msgrtn = "this email is already REGISTERED !";
                        messagebox msgbox = new messagebox();
                        msgbox.labelmsg(msgrtn);
                        msgbox.Show();
                    }
                    cnn.Close();

            }

        }

      

        private void signin_btn_Click_1(object sender, EventArgs e)
        {

            if (email_txt2.Text == "admin" && pass_txt2.Text == "admin123")
            {

                admindashboard admindb = new admindashboard();
                admindb.Show();
 
                
            }
            else
            {
                //code for datastoring and validation
                cnn.Open();
                cmd.CommandText = ("select * from app_users where email='" + email_txt2.Text + "'and password='" + pass_txt2.Text + "'");
                cmd.Connection = cnn;
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    userdashboard userdb = new userdashboard();
                    userdb.Show();
                    LoginInfo.email = email_txt2.Text;
                    //MessageBox.Show(LoginInfo.email);
                 
                }

                else
                {
                    msgrtn = "YOU ARE NOT REGISTERED \n PLEASE SIGNIN";
                    messagebox msgbox = new messagebox();
                    msgbox.labelmsg(msgrtn);
                    msgbox.Show();
                }
                rd.Close();
                cnn.Close();
                
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            password changepass = new password();
            changepass.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
