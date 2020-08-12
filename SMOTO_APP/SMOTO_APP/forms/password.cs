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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMOTO_APP.forms
{
    public partial class password : Form
    {
        public static string msgrtn;
      
        SqlConnection cnn = new SqlConnection("Data Source=Samiyabatool;Initial Catalog=SMOTO_APP;Persist Security Info=True;User ID=samiya;Password=tirmazi1234");
        SqlCommand cmd; 
        public password()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            SmtpClient obj = new SmtpClient();
            obj.Host = "smtp.live.com";
            obj.Port = 587;
            obj.EnableSsl = true;
            obj.DeliveryMethod = SmtpDeliveryMethod.Network;
            obj.UseDefaultCredentials = false;
            obj.Credentials = new NetworkCredential("samiya97@hotmail.com","");


            // mailcompse code

            MailMessage msg = new MailMessage();
            msg.To.Add(email_txt.Text);
            msg.From = new MailAddress("samiya97@hotmail.com");
            msg.Subject = "SMOTO----- TAKE A RIDE ----your password";

            cnn.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from app_users where email ='" + email_txt.Text + "'";
            cmd.Connection = cnn;

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {

                    msg.Body = "Your Name : " + rd[1].ToString() + "\nYour Email : " + rd[2].ToString() + "\nYour Password : " + rd[3].ToString();

                }


            }
            rd.Close();
            cnn.Close();
            obj.Send(msg);

            msgrtn = "Email has been send";
            messagebox msgbox = new messagebox();
            msgbox.labelmsg(msgrtn);
            msgbox.Show();
        }

        private void password_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
