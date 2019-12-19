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
    public partial class dmenu : Form
    {
        public dmenu()
        {
            InitializeComponent();
        }

        private void modelEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model a = new model();

            a.Show();

        }

        private void categoryEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category a = new category();

            a.Show();


        }

        private void productEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productentry a = new productentry();

            a.Show();

        }

        private void distrbutorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistributorMaster a = new DistributorMaster();

            a.Show();

        }

        private void purchaseTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchase a = new purchase();

            a.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login a = new login();

            a.Show();
            this.Hide();


        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCategory a = new ViewCategory();

            a.Show();

        }

        private void distributionMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDistributorMaster a = new ViewDistributorMaster();

            a.Show();

        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel a = new ViewModel();

            a.Show();

        }

        private void productEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewProductEntry a = new ViewProductEntry();

            a.Show();

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPurchase a = new ViewPurchase();

            a.Show();

        }
    }
}
