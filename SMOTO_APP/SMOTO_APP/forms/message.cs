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
    public partial class message : Form
    {
        public static string msgrtn;

        SqlConnection cnn = new SqlConnection("Data Source=Samiyabatool;Initial Catalog=SMOTO_APP;Persist Security Info=True;User ID=samiya;Password=tirmazi1234");
      
        public message()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {

            SmtpClient obj = new SmtpClient();
            obj.Host = "smtp.live.com";
            obj.Port = 25;
            obj.EnableSsl = true;
            obj.DeliveryMethod = SmtpDeliveryMethod.Network;
            obj.UseDefaultCredentials = false;
            obj.Credentials = new NetworkCredential("samiya97@hotmail.com", "");


            // mailcompse code

            MailMessage msg = new MailMessage();
            msg.To.Add("samiyatirmazi@gmail.com");
            msg.From = new MailAddress("samiya97@hotmail.com");
            msg.Subject = "SMOTO---- TAKE A RIDE ----";
            msg.Body = "Name : " + name_txt.Text + "\nEmail : " + email_txt.Text + "\nMessage : " + msg_txt.Text;
            obj.Send(msg);
            msgrtn = "Thank you ! :) \n for Your feedback";
            messagebox msgbox = new messagebox();
            msgbox.labelmsg(msgrtn);
            msgbox.Show();
        }
    }
}
