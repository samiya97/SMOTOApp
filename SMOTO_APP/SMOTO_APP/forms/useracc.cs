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
    public partial class useracc : Form
    {
        SqlConnection cnn = new SqlConnection("Data Source=Samiyabatool;Initial Catalog=SMOTO_APP;Persist Security Info=True;User ID=samiya;Password=tirmazi1234");
        SqlCommand cmd = new SqlCommand();
        public static string msgrtn;
        
        public useracc()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void useracc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMOTO_APPDataSet1.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.sMOTO_APPDataSet1.history);
            showemail.Text = LoginInfo.email;
            cnn.Open();
            cmd.CommandText = "select * from history where email = '"+LoginInfo.email+"'";
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            /////tablefilldatatable
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            // dataGridView1.Refresh();
            cnn.Close();

        }
    }
}
