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

namespace shopmanagement
{
    public partial class category : Form
    {

        SqlConnection db;//open the database
        SqlDataAdapter da;//connection table 
        DataSet ds;//access the database
        SqlCommand cmd;//connection table
        SqlCommandBuilder cb;//connection table
        DataRow dr;//add the data to database

        int count = 0, keyy;

        public category()
        {
            InitializeComponent();
            this.ActiveControl = badd;
        }

        private void badd_Click(object sender, EventArgs e)
        {
            count = ds.Tables["category"].Rows.Count;
            if (count == 0)
            {
                keyy = 1;
            }
            else
            {
                dr = ds.Tables["category"].Rows[count - 1];
                keyy = Convert.ToInt32(dr[0]) + 1;
            }

            bsave.Enabled = true;
            bupdate.Enabled = true;
            bdelete.Enabled = true;

            tname.Text = "";

            tname.Focus();

        }

        private void bsave_Click(object sender, EventArgs e)
        {

            if (tname.Text == "")
            {
                MessageBox.Show("Enter Model Name");
                tname.Focus();
            }
            else
            {
                dr = ds.Tables["category"].NewRow();


                //dr["keyy"] = keyy;
                dr["name"] = tname.Text;

                ds.Tables["category"].Rows.Add(dr);
                da.Update(ds.Tables["category"]);

                MessageBox.Show("Data Entered Successfully");
                bsave.Enabled = false;
                bupdate.Enabled = false;
                bdelete.Enabled = false;

                badd.Focus();

                tname.Text = "";

            }

        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            dr.BeginEdit();
            dr["name"] = tname.Text;

            dr.EndEdit();
            da.Update(ds.Tables["category"]);

            MessageBox.Show("Data Updated Successfully");

            tname.Text = "";

            bupdate.Enabled = false;
            bdelete.Enabled = false;
            badd.Enabled = true;

        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            dr.Delete();
            da.Update(ds.Tables["category"]);

            MessageBox.Show("Data Deleted Successfully");
            tname.Text = "";

            bsave.Enabled = true;
            bupdate.Enabled = false;
            bdelete.Enabled = false;

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {

            dr = ds.Tables["category"].Rows[listBox.SelectedIndex];

            tname.Text = "" + dr[1];

            bupdate.Enabled = true;
            bdelete.Enabled = true;
            bsave.Enabled = false;

            bupdate.Focus();
        }

        private void tname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
           && char.IsDigit(e.KeyChar))

            {

                e.Handled = true;
            }
        }

        private void category_Load(object sender, EventArgs e)
        {
            bsave.Enabled = false;
            bupdate.Enabled = false;
            bdelete.Enabled = false;

            db = new SqlConnection();
            da = new SqlDataAdapter();
            ds = new DataSet();
            cmd = new SqlCommand();
            cb = new SqlCommandBuilder();

            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioDesktopApp\shopmanagement\db\shop.mdf;Integrated Security=True;";
            db.Open(); //open the connection

            cmd.Connection = db;
            cmd.CommandText = "select * from category";

            da.SelectCommand = cmd;
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "category"); //dataadapter is filling the data using dataset of student
            cb.DataAdapter = da;

            listBox.DataSource = ds.Tables["category"];
            listBox.DisplayMember = "name";



        }
    }
}
