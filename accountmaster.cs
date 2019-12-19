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
    public partial class accountmaster : Form
    {
        SqlConnection db;//open the database
        SqlDataAdapter da;//connection table 
        DataSet ds;//access the database
        SqlCommand cmd;//connection table
        SqlCommandBuilder cb;//connection table
        DataRow dr;//add the data to database

        int count = 0, keyy;

        public accountmaster()
        {

            InitializeComponent();
            this.ActiveControl = badd;
        }
        
        private void badd_Click(object sender, EventArgs e)
        {
            count = ds.Tables["amaster"].Rows.Count;
            if (count == 0)
            {
                keyy = 1;
            }
            else
            {
                dr = ds.Tables["amaster"].Rows[count - 1];
                keyy = Convert.ToInt32(dr[0]) + 1;
            }

            bsave.Enabled = true;
            bmodify.Enabled = true;
            bdelete.Enabled = true;

            tname.Text = "";
            tacc.Text = "";
            taccd.Text = "";
            
            tname.Focus();

        }

        private void bsave_Click(object sender, EventArgs e)
        {
            if (tname.Text == "")
            {
                MessageBox.Show("Enter Name");
                tname.Focus();
            }
            else if (tacc.Text == "")
            {
                MessageBox.Show("Enter Account No");
                taccd.Focus();
            }
            else if (tacc.Text == "")
            {
                MessageBox.Show("Enter Account Details");
                taccd.Focus();
            }

            else
            {
                dr = ds.Tables["amaster"].NewRow();


                dr["keyy"] = keyy;
                dr["name"] = tname.Text;
                dr["acc"] = tacc.Text;
                dr["accd"] = taccd.Text;
                
                ds.Tables["amaster"].Rows.Add(dr);
                da.Update(ds.Tables["amaster"]);

                MessageBox.Show("Data Entered Successfully");
                bsave.Enabled = false;
                bmodify.Enabled = false;
                bdelete.Enabled = false;

                badd.Focus();

                tname.Text = "";
                tacc.Text = "";
                taccd.Text = "";
                
            }

        }

        private void bmodify_Click(object sender, EventArgs e)
        {
            dr.BeginEdit();
            dr["name"] = tname.Text;
            dr["acc"] = tacc.Text;
            dr["accd"] = taccd.Text;
            
            dr.EndEdit();
            da.Update(ds.Tables["amaster"]);

            MessageBox.Show("Data Updated Successfully");

            tname.Text = "";
            tacc.Text = "";
            taccd.Text = "";
           
            bmodify.Enabled = false;
            bdelete.Enabled = false;
            badd.Enabled = true;

        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            dr.Delete();
            da.Update(ds.Tables["amaster"]);

            MessageBox.Show("Data Deleted Successfully");
            tname.Text = "";
            tacc.Text = "";
            taccd.Text = "";
            
            bsave.Enabled = true;
            bmodify.Enabled = false;
            bdelete.Enabled = false;

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            dr = ds.Tables["dmaster"].Rows[listBox.SelectedIndex];

            tname.Text = "" + dr[1];
            tacc.Text = "" + dr[2];
            taccd.Text = "" + dr[3];
            
            bmodify.Enabled = true;
            bdelete.Enabled = true;
            bsave.Enabled = false;

            bmodify.Focus();

        }

        private void accountmaster_Load(object sender, EventArgs e)
        {
            bsave.Enabled = false;
            bmodify.Enabled = false;
            bdelete.Enabled = false;

            db = new SqlConnection();
            da = new SqlDataAdapter();
            ds = new DataSet();
            cmd = new SqlCommand();
            cb = new SqlCommandBuilder();

            // db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\demo\db\stock.mdf; Integrated Security = True";

            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioDesktopApp\shopmanagement\db\shop.mdf;Integrated Security=True;";
            db.Open(); //open the connection

            cmd.Connection = db;
            cmd.CommandText = "select * from amaster";

            da.SelectCommand = cmd;
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "amaster"); //dataadapter is filling the data using dataset of student
            cb.DataAdapter = da;

            listBox.DataSource = ds.Tables["amaster"];
            listBox.DisplayMember = "name";
        }
    }
    
}
