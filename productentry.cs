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
    public partial class productentry : Form
    {
        SqlConnection db;//open the database
        SqlDataAdapter da, da1, da2;//connection table 
        DataSet ds, ds1, ds2;//access the database
        SqlCommand cmd, cmd1, cmd2;//connection table
        SqlCommandBuilder cb, cb1, cb2;//connection table

        private void bdelete_Click(object sender, EventArgs e)
        {
            dr.Delete();
            da.Update(ds.Tables["pentry"]);

            MessageBox.Show("Data Deleted Successfully");

            tsku.Text = "";
            tcname.Text = "";
            tmname.Text = "";
            tdesc.Text = "";
            tcode.Text = "";


            bsave.Enabled = true;
            bmodify.Enabled = false;
            bdelete.Enabled = false;

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            dr = ds.Tables["pentry"].Rows[listBox1.SelectedIndex];

            tsku.Text = "" + dr[1];
            tcname.Text = "" + dr[2];
            tmname.Text = "" + dr[3];
            tdesc.Text = "" + dr[4];
            tcode.Text = "" + dr[5];

            bmodify.Enabled = true;
            bdelete.Enabled = true;
            bsave.Enabled = false;

            bmodify.Focus();

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void csearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = ds.Tables["pentry"].Rows[listBox1.SelectedIndex];

            tsku.Text = "" + dr[1];
            tcname.Text = "" + dr[2];
            tmname.Text = "" + dr[3];
            tdesc.Text = "" + dr[4];
            tcode.Text = "" + dr[5];

           
        }

        DataRow dr;//add the data to database

        int count = 0, keyy;

        String skscode, cnaem, mname, desc, hsncode;
        public productentry()
        {

            InitializeComponent();
            this.ActiveControl = badd;
        }

        private void bmodify_Click(object sender, EventArgs e)
        {
            dr.BeginEdit();
            dr["keyy"] = keyy;
            dr["sku"] = tsku.Text;
            dr["cname"] = tcname.Text;
            dr["mname"] = tmname.Text;
            dr["desc"] = tdesc.Text;
            dr["code"] = tcode.Text;

            dr.EndEdit();
            da.Update(ds.Tables["pentry"]);

            MessageBox.Show("Data Updated Successfully");


            tsku.Text = "";
            tcname.Text = "";
            tmname.Text = "";
            tdesc.Text = "";
            tcode.Text = "";


            bmodify.Enabled = false;
            bdelete.Enabled = false;
            badd.Enabled = true;

        }

        private void badd_Click(object sender, EventArgs e)
        {
            count = ds.Tables["pentry"].Rows.Count;
            if (count == 0)
            {
                keyy = 1;
            }
            else
            {
                dr = ds.Tables["pentry"].Rows[count - 1];
                keyy = Convert.ToInt32(dr[0]) + 1;
            }

            bsave.Enabled = true;
            bmodify.Enabled = true;
            bdelete.Enabled = true;

            tsku.Text = "";
            tcname.Text = "";
            tmname.Text = "";
            tdesc.Text = "";
            tcode.Text = "";

            tsku.Focus();

        }

        private void bsave_Click(object sender, EventArgs e)
        {
            if (tsku.Text == "")
            {
                MessageBox.Show("Enter SKU Code");
                tsku.Focus();
            }
            else if (tcname.Text == "")
            {
                MessageBox.Show("Enter Category Name");
                tcname.Focus();
            }
            else if (tmname.Text == "")
            {
                MessageBox.Show("Enter Model Name");
                tmname.Focus();
            }
            else if (tcode.Text == "")
            {
                MessageBox.Show("Enter HSN / SAC Code");
                tcode.Focus();
            }

            else
            {
                dr = ds.Tables["pentry"].NewRow();


                dr["keyy"] = keyy;
                dr["sku"] = tsku.Text;
                dr["cname"] = tcname.Text;
                dr["mname"] = tmname.Text;
                dr["desc"] = tdesc.Text;
                dr["code"] = tcode.Text;

                ds.Tables["pentry"].Rows.Add(dr);
                da.Update(ds.Tables["pentry"]);

                MessageBox.Show("Data Entered Successfully");
                bsave.Enabled = false;
                bmodify.Enabled = false;
                bdelete.Enabled = false;

                badd.Focus();


                tsku.Text = "";
                tcname.Text = "";
                tmname.Text = "";
                tdesc.Text = "";
                tcode.Text = "";

            }

        }
       
        private void productentry_Load(object sender, EventArgs e)
        {
            bsave.Enabled = false;
            bmodify.Enabled = false;
            bdelete.Enabled = false;

            db = new SqlConnection();
            da = new SqlDataAdapter();
            ds = new DataSet();
            cmd = new SqlCommand();
            cb = new SqlCommandBuilder();

            da1 = new SqlDataAdapter();
            ds1 = new DataSet();
            cmd1 = new SqlCommand();
            cb1 = new SqlCommandBuilder();

            da2 = new SqlDataAdapter();
            ds2 = new DataSet();
            cmd2 = new SqlCommand();
            cb2 = new SqlCommandBuilder();

            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioDesktopApp\shopmanagement\db\shop.mdf;Integrated Security=True;";
            db.Open(); //open the connection

            cmd.Connection = db;
            cmd1.Connection = db;
            cmd2.Connection = db;

            cmd.CommandText = "select * from pentry";
            cmd1.CommandText = "select * from category ";
            cmd2.CommandText = "select * from model";

            da.SelectCommand = cmd;
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "pentry"); //dataadapter is filling the data using dataset of student
            cb.DataAdapter = da;

            da1.SelectCommand = cmd1;
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da1.Fill(ds1, "category"); //dataadapter is filling the data using dataset of student
            cb1.DataAdapter = da1;

            da2.SelectCommand = cmd2;
            da2.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da2.Fill(ds2, "model"); //dataadapter is filling the data using dataset of student
            cb2.DataAdapter = da2;

            tcname.DataSource = ds1.Tables["category"];
            tcname.DisplayMember = "name";


            tmname.DataSource = ds2.Tables["model"];
            tmname.DisplayMember = "name";

            listBox1.DataSource = ds.Tables["pentry"];
            listBox1.DisplayMember = "sku";

        }
    }
}
