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
    public partial class admindashboard : Form
    {
        SqlConnection cnn = new SqlConnection("Data Source=Samiyabatool;Initial Catalog=SMOTO_APP;Persist Security Info=True;User ID=samiya;Password=tirmazi1234");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        public static string msgrtn;
       int rowindex;
       

        
        public admindashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            showpanel.Visible = true;
            panel1.Visible = true;
            dataGridView1.Enabled = true;
            dataGridView1.Visible = true;
            panel2.Visible = false;
            dataGridView2.Enabled = false;
            dataGridView2.Visible = false;
            dataGridView3.Enabled = false;
            dataGridView3.Visible = false;
        }

        private void route_btn_Click(object sender, EventArgs e)
        {
            showpanel.Visible = true;
            panel2.Visible = true;
            dataGridView2.Enabled = true;
            dataGridView2.Visible = true;
            panel1.Visible = false;
            dataGridView1.Enabled = false;
            dataGridView1.Visible = false;
            dataGridView3.Enabled = false;
            dataGridView3.Visible = false;
        }


        private void view_btn_Click(object sender, EventArgs e)
        {
            //user table
            if (dataGridView1.Enabled == true)
            {
                //user table
                cnn.Open();
                cmd.CommandText = "select * from app_users";
                cmd.Connection = cnn;

                DataTable dt = new DataTable();
                /////tablefilldatatable
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                // dataGridView1.Refresh();
                cnn.Close();
            }
            else
            {
                //routes table
                cnn.Open();
                cmd1.CommandText = "select * from Routes ";
                cmd1.Connection = cnn;

                DataTable dt1 = new DataTable();
                /////tablefilldatatable
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                sda1.Fill(dt1);
                dataGridView2.DataSource = dt1;
                // dataGridView1.Refresh();
                cnn.Close();
            }
        }
        private void admindashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMOTO_APPDataSet1.app_users' table. You can move, or remove it, as needed.
            this.app_usersTableAdapter1.Fill(this.sMOTO_APPDataSet1.app_users);
            // TODO: This line of code loads data into the 'sMOTO_APPDataSet1.Routes' table. You can move, or remove it, as needed.
            this.routesTableAdapter1.Fill(this.sMOTO_APPDataSet1.Routes);
            // TODO: This line of code loads data into the 'sMOTO_APPDataSet1.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.sMOTO_APPDataSet1.history);
         
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
             //user table
            if (dataGridView1.Enabled == true)
            {
 
                cnn.Open();
                cmd.CommandText = "update app_users set username='" + nametxt.Text + "' ,email='" + emailtxt.Text + "',password='" + passtxt.Text + "' where id='" + idtxt.Text + "'";
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                cnn.Close();
                msgrtn = "USER UPDATED!";
                messagebox msgbox = new messagebox();
                msgbox.labelmsg(msgrtn);
                msgbox.Show();
               
            }
            else
            {
                //routes table

                cnn.Open();
                cmd1.CommandText = "update Routes set Pickup_loc='" + pickuptxt.Text + "',Dropoff_loc='" + dropofftxt.Text + "',Auto='" + autotxt.Text + "',Go='" + gotxt.Text + "',Go_plus='" + goplstxt.Text + "' where r_id='" + r_idtxt.Text + "'";
                cmd1.Connection = cnn;
                cmd1.ExecuteNonQuery();
                cnn.Close();
                msgrtn = "ROUTE UPDATED!";
                messagebox msgbox = new messagebox();
                msgbox.labelmsg(msgrtn);
                msgbox.Show();
              
            }
            
        }
       
        private void delete_btn_Click(object sender, EventArgs e)
        {
            //user table
            if (dataGridView1.Enabled == true)
            {
                String email = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                cnn.Open();
                cmd.CommandText = "delete from app_users where email='" + email + "'";
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                cnn.Close();
                msgrtn = "USER DELETED !";
                messagebox msgbox = new messagebox();
                msgbox.labelmsg(msgrtn);
                msgbox.Show();
            }
            else
            {
                //routes table
                String rid = dataGridView2.Rows[rowindex].Cells[5].Value.ToString();
                cnn.Open();
                cmd1.CommandText = "delete  from Routes where r_id ='" + rid + "'";
                cmd1.Connection = cnn;
                cmd1.ExecuteNonQuery();
                cnn.Close();
                msgrtn = "ROUTE DELETED !";
                messagebox msgbox = new messagebox();
                msgbox.labelmsg(msgrtn);
                msgbox.Show();
            }
        }

      

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            idtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nametxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            emailtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            passtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            pickuptxt.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            dropofftxt.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            autotxt.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            gotxt.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            goplstxt.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            r_idtxt.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            //user table
            if (dataGridView1.Enabled == true)
            {

                cnn.Open();
                cmd.CommandText = "insert into app_users ( username,email,password) values('" + nametxt.Text + "' ,'" + emailtxt.Text + "','" + passtxt.Text + "') ";
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                cnn.Close();
                msgrtn = "USER INSERTED!";
                messagebox msgbox = new messagebox();
                msgbox.labelmsg(msgrtn);
                msgbox.Show();

            }
            else
            {
                //routes table

                cnn.Open();
                cmd1.CommandText = "insert into Routes  (Pickup_loc,Dropoff_loc,Auto,Go,Go_plus) values ('" + pickuptxt.Text + "','" + dropofftxt.Text + "','" + autotxt.Text + "','" + gotxt.Text + "','" + goplstxt.Text + "')";
                cmd1.Connection = cnn;
                cmd1.ExecuteNonQuery();
                cnn.Close();
                msgrtn = "ROUTE INSERTED!";
                messagebox msgbox = new messagebox();
                msgbox.labelmsg(msgrtn);
                msgbox.Show();

            }
        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            showpanel.Visible = true;
            panel2.Visible = false;
            dataGridView2.Enabled = false;
            dataGridView2.Visible = false;
            panel1.Visible = false;
            dataGridView1.Enabled = false;
            dataGridView1.Visible = false;
            dataGridView3.Enabled = true;
            dataGridView3.Visible = true;
        }



       
  
       
  
    }
}
