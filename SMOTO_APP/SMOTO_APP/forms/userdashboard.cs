using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SMOTO_APP.forms
{
    public partial class userdashboard : Form
    {
        SqlConnection cnn = new SqlConnection("Data Source=Samiyabatool;Initial Catalog=SMOTO_APP;Persist Security Info=True;User ID=samiya;Password=tirmazi1234");
        SqlCommand cmd = new SqlCommand();
        public static string msgrtn;

        public userdashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

    

        private void pick_cb_MouseClick(object sender, MouseEventArgs e)
        {
            cnn.Open();

            cmd.CommandText = "select * from Routes ";
            cmd.Connection = cnn;

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                pick_cb.Items.Clear();
                while (rd.Read())
                {

                    pick_cb.Items.Add(rd[0].ToString());


                }
              
            }
        
            rd.Close();
            cnn.Close();
        }

        private void drop_cb_Click(object sender, EventArgs e)
        {
            cnn.Open();

            cmd.CommandText = "select * from Routes ";
            cmd.Connection = cnn;
            SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    drop_cb.Items.Clear();
                    while (rd.Read())
                    {
                        
                        drop_cb.Items.Add(rd[1].ToString());


                    }

                }
                rd.Close();    
            cnn.Close();
        }

        private void Auto_btn_Click(object sender, EventArgs e)
        {
            String pickup = pick_cb.SelectedItem.ToString();
            String dropoff = drop_cb.SelectedItem.ToString();
            String auto;
            showpanel.Visible = true;
            service.Text = "SMOTO AUTO Rickshaw";
            pick_lb.Text = pickup;
            drop_lb.Text = dropoff;
            cnn.Open();
            cmd.CommandText = "select * from Routes where Pickup_loc='"+pickup+"' and Dropoff_loc='"+dropoff+"'";
            cmd.Connection = cnn;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows) {
                while (rd.Read()) {
                     auto = rd[2].ToString();
                     fare_lb.Text = auto +" Rs";
            }
        }
            rd.Close(); 
            cnn.Close();
        }

   

        private void Go_btn_Click(object sender, EventArgs e)
        {
            String pickup = pick_cb.SelectedItem.ToString();
            String dropoff = drop_cb.SelectedItem.ToString();
            String GO;
            showpanel.Visible = true;
            service.Text = "SMOTO Go Car";
            pick_lb.Text = pickup;
            drop_lb.Text = dropoff;
            cnn.Open();
            cmd.CommandText = "select * from Routes where Pickup_loc='" + pickup + "' and Dropoff_loc='" + dropoff + "'";
            cmd.Connection = cnn;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    GO = rd[3].ToString();
                    fare_lb.Text = GO + " Rs";
                }
            }
            rd.Close(); 
            cnn.Close();
        }

        private void Gopls_btn_Click(object sender, EventArgs e)
        {
            String pickup = pick_cb.SelectedItem.ToString();
            String dropoff = drop_cb.SelectedItem.ToString();
            String GOpls;
            showpanel.Visible = true;
            service.Text = "SMOTO GO++ Car";
            pick_lb.Text = pickup;
            drop_lb.Text = dropoff;
            cnn.Open();
            cmd.CommandText = "select * from Routes where Pickup_loc='" + pickup + "' and Dropoff_loc='" + dropoff + "'";
            cmd.Connection = cnn;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    GOpls = rd[4].ToString();
                    fare_lb.Text = GOpls + " Rs";
                }
            }
            rd.Close(); 
            cnn.Close();
        }

        private void ridebtn_Click(object sender, EventArgs e)
        {
            msgrtn = "HAVE A NICE RIDE \n PLEASE GIVE US A FEEDBACK";
            messagebox msgbox = new messagebox();
            msgbox.labelmsg(msgrtn);
            msgbox.Show();
            cnn.Open();
            cmd.CommandText = "insert into history values('" +LoginInfo.email+ "', '" + pick_lb.Text + "', '" + drop_lb.Text + "' , '"+fare_lb.Text+"')";
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            message fb_form = new message();
            fb_form.Show();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            useracc acc = new useracc();
            acc.Show();

        }

     


    }
}
