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
    public partial class DistributorMaster : Form
    {
        SqlConnection db;//open the database
        SqlDataAdapter da;//connection table 
        DataSet ds;//access the database
        SqlCommand cmd;//connection table
        SqlCommandBuilder cb;//connection table
        DataRow dr;//add the data to database

        int count = 0, keyy;

        public DistributorMaster()
        {
            InitializeComponent();
            this.ActiveControl = badd;
        }

        private void badd_Click(object sender, EventArgs e)
        {
            count = ds.Tables["dmaster"].Rows.Count;
            if (count == 0)
            {
                keyy = 1;
            }
            else
            {
                dr = ds.Tables["dmaster"].Rows[count - 1];
                keyy = Convert.ToInt32(dr[0]) + 1;
            }

            bsave.Enabled = true;
            bmodify.Enabled = true;
            bdelete.Enabled = true;

            tname.Text = "";
            taddress.Text = "";
            tacc.Text = "";
            tphone.Text = "";
            tgst.Text = "";

            tname.Focus();

        }

        private void bsave_Click(object sender, EventArgs e)
        {
            if (tname.Text == "")
            {
                MessageBox.Show("Enter Distributor Name");
                tname.Focus();
            }
            else if (taddress.Text == "")
            {
                MessageBox.Show("Enter Distributor Address");
                taddress.Focus();
            }
            else if (tacc.Text == "")
            {
                MessageBox.Show("Enter Distributor Account No");
                tacc.Focus();
            }
            else if (tphone.Text == "")
            {
                MessageBox.Show("Enter Distributor Monile No");
                tphone.Focus();
            }
            else if (tgst.Text == "")
            {
                MessageBox.Show("Enter GSTIN");
                tgst.Focus();
            }
            else
            {
                dr = ds.Tables["dmaster"].NewRow();


                dr["keyy"] = keyy;
                dr["name"] = tname.Text;
                dr["address"] = taddress.Text;
                dr["account"] = tacc.Text;
                dr["phone"] = tphone.Text;
                dr["gst"] = tgst.Text;

                ds.Tables["dmaster"].Rows.Add(dr);
                da.Update(ds.Tables["dmaster"]);

                MessageBox.Show("Data Entered Successfully");
                bsave.Enabled = false;
                bmodify.Enabled = false;
                bdelete.Enabled = false;

                badd.Focus();

                tname.Text = "";
                taddress.Text = "";
                tacc.Text = "";
                tphone.Text = "";
                tgst.Text = "";

            }
        }
private void bmodify_Click(object sender, EventArgs e)
        {
            dr.BeginEdit();
            dr["name"] = tname.Text;
            dr["address"] = taddress.Text;
            dr["account"] = tacc.Text;
            dr["phone"] = tphone.Text;
            dr["gst"] = tgst.Text;

            dr.EndEdit();
            da.Update(ds.Tables["dmaster"]);

            MessageBox.Show("Data Updated Successfully");

            tname.Text = "";
            taddress.Text = "";
            tacc.Text = "";
            tphone.Text = "";
            tgst.Text = "";

            bmodify.Enabled = false;
            bdelete.Enabled = false;
            badd.Enabled = true;

        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            dr.Delete();
            da.Update(ds.Tables["dmaster"]);

            MessageBox.Show("Data Deleted Successfully");
            tname.Text = "";
            taddress.Text = "";
            tacc.Text = "";
            tphone.Text = "";
            tgst.Text = "";

            bsave.Enabled = true;
            bmodify.Enabled = false;
            bdelete.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lname_DoubleClick(object sender, EventArgs e)
        {
            dr = ds.Tables["dmaster"].Rows[lname.SelectedIndex];

            tname.Text = "" + dr[1];
            taddress.Text = "" + dr[2];
            tacc.Text = "" + dr[3];
            tphone.Text = "" + dr[4];
            tgst.Text = "" + dr[5];

            bmodify.Enabled = true;
            bdelete.Enabled = true;
            bsave.Enabled = false;

            bmodify.Focus();
        }

        private void tname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
           && char.IsDigit(e.KeyChar))

            {

                e.Handled = true;
            }
        }

        private void tacc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar)
           && !char.IsDigit(e.KeyChar)
           /*&& e.KeyChar != '.'*/)

            {

                e.Handled = true;
            }
        }

        private void tphone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsControl(e.KeyChar)
           && !Char.IsDigit(e.KeyChar)
          /* && e.KeyChar != '.'*/)

            {

                e.Handled = true;
            }

            //or
            /*if (e.KeyChar >= '0' && e.KeyChar <= '9')//the character represents
            {
            e.Handled = false;//do not reject the input
            }
            else
            {
                    e.Handled = true;//reject the input
             }*/
        }

        private void tname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                taddress.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                tname.Focus();
            }
        }

        private void taddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tacc.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                taddress.Focus();
            }
        }

        private void tacc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tphone.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                tacc.Focus();
            }
        }

        private void tphone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tgst.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                tphone.Focus();
            }
        }

        private void tgst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bsave.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                tgst.Focus();
            }

        }

        private void DistributorMaster_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from dmaster";

            da.SelectCommand = cmd;
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "dmaster"); //dataadapter is filling the data using dataset of student
            cb.DataAdapter = da;

            lname.DataSource = ds.Tables["dmaster"];
            lname.DisplayMember = "name";
        }
    }
}
