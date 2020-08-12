using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMOTO_APP.forms
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void login_btn_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
        }
    }
}
