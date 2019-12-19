using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopmanagement
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
            this.ActiveControl = tlid;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void fexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flogin_Click(object sender, EventArgs e)
        {
            if (tlid.Text == "admin" && tpass.Text =="1234")
            {
                dmenu a = new dmenu();
                
                a.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid Details");
            }
        }
    }
}
