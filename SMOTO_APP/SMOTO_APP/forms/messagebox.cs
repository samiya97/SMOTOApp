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
    
    public partial class messagebox : Form
    {
        public string msgrtn;
        public messagebox()
        {
            InitializeComponent();
        }

        private void singup_btn_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void labelmsg(string lbmsg) {
          
            label1.Text = lbmsg;
        
        }

        private void messagebox_Load(object sender, EventArgs e)
        {

        }
    }
}
