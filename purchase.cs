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
    public partial class purchase : Form
    {

        SqlConnection db;       //open the database
        SqlDataAdapter da, da1, da2, da3;       //connection table
        DataSet ds, ds1, ds2, ds3;                //access the database

        SqlCommand cmd, cmd2, cmd1, cmd3;    //connection table
        SqlCommandBuilder cb, cb1, cb2, cb3;

        DataRow dr, dr1, dr2, dr3;                    //add data to database



        int count = 0, count1 = 0, keyy;

        private void datetime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                datetime.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                tino.Focus();
            }

        }

        private void cdname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cdname.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                datetime.Focus();
            }

        }

        private void textgst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                csku.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                textgst.Focus();
            }

        }

        private void csku_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tino.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                csku.Focus();
            }


        }

        private void cbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = ds.Tables["purchase"].Rows[listBox1.SelectedIndex];

            tino.Text = "" + dr[1];
            datetime.Text = "" + dr[2];
            cdname.Text = "" + dr[3];
            textgst.Text = "" + dr[4];
            csku.Text = "" + dr[5];
            tcat.Text = "" + dr[6];
            tmodel.Text = "" + dr[7];
            tdesc.Text = "" + dr[8];
            texthsn.Text = "" + dr[9];
            tquantity.Text = "" + dr[10];
            trate.Text = "" + dr[11];
            ttotal.Text = "" + dr[12];
            tcgstrate.Text = "" + dr[13];
            tcgstamt.Text = "" + dr[14];
            tsgstrate.Text = "" + dr[15];
            tsgstamt.Text = "" + dr[16];
            ttax.Text = "" + dr[17];
            ctransaction.Text = "" + dr[18];
            caccname.Text = "" + dr[19];
            taccno.Text = "" + dr[20];
            taccdetail.Text = "" + dr[21];
            ttotamt.Text = "" + dr[22];
            tpaidamt.Text = "" + dr[23];
            tpend.Text = "" + dr[24];

            bedit.Focus();
        }

        private void tino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tino.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                badd.Focus();
            }

        }

        private void tsgstrate_TextChanged(object sender, EventArgs e)
        {
            if (ttotal.Text.Length > 0 && tsgstrate.Text.Length > 0)
            {
                tsgstamt.Text = Convert.ToString((Convert.ToInt32(ttotal.Text) * Convert.ToInt32(tsgstrate.Text)) / 100);
                ttax.Text = Convert.ToString(Convert.ToInt32(ttotal.Text) + Convert.ToInt32(tcgstamt.Text) + Convert.ToInt32(tsgstamt.Text));
                ttotamt.Text = ttax.Text;
            }
        }

        private void tpaidamt_TextChanged(object sender, EventArgs e)
        {
            if (ttotamt.Text.Length > 0 && tpaidamt.Text.Length > 0)
            {
                tpend.Text = Convert.ToString((Convert.ToInt32(ttotamt.Text) - Convert.ToInt32(tpaidamt.Text)));
            }
        }

        private void cdname_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = ds1.Tables["dmaster"].Rows[cdname.SelectedIndex];
            textgst.Text = "" + dr[5];
            csku.Focus();
        }

        private void csku_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr2 = ds2.Tables["pentry"].Rows[csku.SelectedIndex];
            tcat.Text = "" + dr2[2];
            tmodel.Text = "" + dr2[3];
            tdesc.Text = "" + dr2[4];
            texthsn.Text = "" + dr2[5];
            tquantity.Focus();
        }

        private void caccname_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr3 = ds3.Tables["amaster"].Rows[caccname.SelectedIndex];
            taccno.Text = "" + dr3[2];
            taccdetail.Text = "" + dr3[3];
            tpaidamt.Focus();
        }

       private void ctransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            count1 = ctransaction.SelectedIndex;
            if (count1 == 0)
            {
                caccname.Enabled = false;
                taccdetail.Enabled = false;
                taccno.Enabled = false;
                /*caccname.Text = "-------";
                taccno.Text = "-------";
                taccdetail.Text = "-------";*/
            }
            else if (count1 == 1)
            {
                caccname.Enabled = true;
                taccdetail.Enabled = true;
                taccno.Enabled = true;
                caccname.Focus();
            }

        }
        private void tcgstrate_TextChanged(object sender, EventArgs e)
        {

            if (ttotal.Text.Length > 0 && tcgstrate.Text.Length > 0)
            {
                tcgstamt.Text = Convert.ToString((Convert.ToInt32(ttotal.Text) * Convert.ToInt32(tcgstrate.Text)) / 100);
            }

        }

        private void trate_TextChanged(object sender, EventArgs e)
        {


            if (tquantity.Text.Length > 0 && trate.Text.Length > 0)
            {
                ttotal.Text = Convert.ToString((Convert.ToInt32(tquantity.Text) * Convert.ToInt32(trate.Text)));
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            dr = ds.Tables["purchase"].Rows[listBox1.SelectedIndex];

            tino.Text = "" + dr[1];
            datetime.Text = "" + dr[2];
            cdname.Text = "" + dr[3];
            textgst.Text = "" + dr[4];
            csku.Text = "" + dr[5];
            tcat.Text = "" + dr[6];
            tmodel.Text = "" + dr[7];
            tdesc.Text = "" + dr[8];
            texthsn.Text = "" + dr[9];
            tquantity.Text = "" + dr[10];
            trate.Text = "" + dr[11];
            ttotal.Text = "" + dr[12];
            tcgstrate.Text = "" + dr[13];
            tcgstamt.Text = "" + dr[14];
            tsgstrate.Text = "" + dr[15];
            tsgstamt.Text = "" + dr[16];
            ttax.Text = "" + dr[17];
            ctransaction.Text = "" + dr[18];
            caccname.Text = "" + dr[19];
            taccno.Text = "" + dr[20];
            taccdetail.Text = "" + dr[21];
            ttotamt.Text = "" + dr[22];
            tpaidamt.Text = "" + dr[23];
            tpend.Text = "" + dr[24];
            bedit.Enabled = true;
            bdelete.Enabled = true;
            bsave.Enabled = false;
            badd.Enabled = false;
        }

        private void bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void badd_Click(object sender, EventArgs e)
        {
            count = ds.Tables["purchase"].Rows.Count;
            if (count == 0)
            {
                keyy = 1;
            }
            else
            {
                dr = ds.Tables["purchase"].Rows[count - 1];
                keyy = Convert.ToInt32(dr[0]) + 1;
                //keyy = Convert.ToInt64(dr[0]) + 1;          

            }
            
            bedit.Enabled = true;
            bsave.Enabled = true;
            bdelete.Enabled = true;

            tino.Text = "";
            datetime.Text = "";
            cdname.Text = "";
            textgst.Text = "";
            csku.Text = "";
            tcat.Text = "";
            tmodel.Text = "";
            tdesc.Text = "";
            texthsn.Text = "";
            tquantity.Text = "";
            trate.Text = "";
            ttotal.Text = "";
            tcgstrate.Text = "";
            tcgstamt.Text = "";
            tsgstamt.Text = "";
            tsgstrate.Text = "";
            ttax.Text = "";
            ctransaction.Text = "";
            caccname.Text = "";
            taccno.Text = "";
            taccdetail.Text = "";
            tpaidamt.Text = "";
            ttotamt.Text = "";
            tpend.Text = "";
            tino.Focus();
            Console.WriteLine("" + keyy);
            tino.Text = "NE-" + keyy;



        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            dr.Delete();
            da.Update(ds.Tables["purchase"]);
            MessageBox.Show("Delete Successfully");
            tino.Text = "";
            datetime.Text = "";
            cdname.Text = "";
            textgst.Text = "";
            csku.Text = "";
            tcat.Text = "";
            tmodel.Text = "";
            tdesc.Text = "";
            texthsn.Text = "";
            tquantity.Text = "";
            trate.Text = "";
            ttotal.Text = "";
            tcgstamt.Text = "";
            tcgstamt.Text = "";
            tsgstamt.Text = "";
            tsgstrate.Text = "";
            ttax.Text = "";
            ctransaction.Text = "";
            caccname.Text = "";
            taccno.Text = "";
            taccdetail.Text = "";
            tpaidamt.Text = "";
            ttotamt.Text = "";
            tpend.Text = "";
            bedit.Enabled = false;
            bdelete.Enabled = false;
            badd.Enabled = true;
            badd.Focus();
        }

        



        private void bedit_Click(object sender, EventArgs e)
        {

            if (tino.Text == "")
            {
                MessageBox.Show("Invalid Invoice No.");
                tino.Focus();
            }
            else if (tmodel.Text == "")
            {
                MessageBox.Show("Invalid model");
                tmodel.Focus();
            }
            else if (texthsn.Text == "")
            {
                MessageBox.Show("Invalid hsn");
                texthsn.Focus();
            }
            else if (taccno.Text == "")
            {
                MessageBox.Show("Invalid account no");
                taccno.Focus();
            }
            else if (ttax.Text == "")
            {
                MessageBox.Show("Invalid tax ammount");
                ttax.Focus();
            }
            else
            {
                dr.BeginEdit();
                dr["keyy"] = keyy;
                dr["invoice"] = tino.Text;
                dr["date"] = datetime.Text;
                dr["dname"] = cdname.Text;
                dr["gstin"] = textgst.Text;
                dr["sku"] = csku.Text;
                dr["category"] = tcat.Text;
                dr["mname"] = tmodel.Text;
                dr["description"] = tdesc.Text;
                dr["hsn"] = texthsn.Text;
                dr["quantity"] = tquantity.Text;
                dr["rate"] = trate.Text;
                dr["total"] = ttotal.Text;
                dr["cgst_rate"] = tcgstrate.Text;
                dr["cgst_amt"] = tcgstamt.Text;
                dr["sgst_rate"] = tsgstrate.Text;
                dr["sgst_amt"] = tsgstamt.Text;
                dr["tax_value"] = ttax.Text;
                dr["transaction_type"] = ctransaction.Text;
                dr["account_name"] = caccname.Text;
                dr["account_no"] = taccno.Text;
                dr["account_detail"] = taccdetail.Text;
                dr["total_amt"] = ttotamt.Text;
                dr["paid_amt"] = tpaidamt.Text;
                dr["pending_amt"] = tpend.Text;
                dr.EndEdit();
                // ds.Tables["distribution"].Rows.Add(dr);
                da.Update(ds.Tables["purchase"]);
                MessageBox.Show("Data Updated Succesfully");
                badd.Enabled = true;
                badd.Focus();
            }
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            if (tino.Text == "")
            {
                MessageBox.Show("Invalid Invoice No.");
                tino.Focus();
            }
            else if (tmodel.Text == "")
            {
                MessageBox.Show("Invalid model");
                tmodel.Focus();
            }
            else if (texthsn.Text == "")            //.text=All Text Data
            {
                MessageBox.Show("Invalid hsn");
                texthsn.Focus();
            }
            else if (taccno.Text == "")
            {
                MessageBox.Show("Invalid account no");
                taccno.Focus();
            }
            else if (ttax.Text == "")
            {
                MessageBox.Show("Invalid tax ammount");
                ttax.Focus();
            }
            else
            {
                dr = ds.Tables["purchase"].NewRow();
                dr["keyy"] = keyy;
                dr["invoice"] = tino.Text;
                dr["date"] = datetime.Text;
                dr["dname"] = cdname.Text;
                dr["gstin"] = textgst.Text;
                dr["sku"] = csku.Text;
                dr["category"] = tcat.Text;
                dr["mname"] = tmodel.Text;
                dr["description"] = tdesc.Text;
                dr["hsn"] = texthsn.Text;
                dr["quantity"] = tquantity.Text;
                dr["rate"] = trate.Text;
                dr["total"] = ttotal.Text;
                dr["cgst_rate"] = tcgstrate.Text;
                dr["cgst_amt"] = tcgstamt.Text;
                dr["sgst_rate"] = tsgstrate.Text;
                dr["sgst_amt"] = tsgstamt.Text;
                dr["tax_value"] = ttax.Text;
                dr["transaction_type"] = ctransaction.Text;
                dr["account_name"] = caccname.Text;
                dr["account_no"] = taccno.Text;
                dr["account_detail"] = taccdetail.Text;
                dr["total_amt"] = ttotamt.Text;
                dr["paid_amt"] = tpaidamt.Text;
                dr["pending_amt"] = tpend.Text;

                ds.Tables["purchase"].Rows.Add(dr);
                da.Update(ds.Tables["purchase"]);


                MessageBox.Show("Data Enter Successfully");
                bsave.Enabled = false;
                bedit.Enabled = false;
                bdelete.Enabled = false;
                // tname.Focus();
                tino.Text = "";
                datetime.Text = "";
                cdname.Text = "";
                textgst.Text = "";
                csku.Text = "";
                tcat.Text = "";
                tmodel.Text = "";
                tdesc.Text = "";
                texthsn.Text = "";
                tquantity.Text = "";
                trate.Text = "";
                ttotal.Text = "";

                tcgstamt.Text = "";
                tcgstamt.Text = "";

                tsgstamt.Text = "";
                tsgstrate.Text = "";

                ttax.Text = "";
                ctransaction.Text = "";
                caccname.Text = "";
                taccno.Text = "";
                taccdetail.Text = "";
                tpaidamt.Text = "";
                ttotamt.Text = "";
                tpend.Text = "";
                bedit.Enabled = false;
                bdelete.Enabled = false;
                badd.Enabled = true;
                badd.Focus();

            }
        }


        public purchase()
        {
            InitializeComponent();
            this.ActiveControl = badd;
        }

        private void purchase_Load(object sender, EventArgs e)
        {
            ctransaction.Items.Add("Cash");
            ctransaction.Items.Add("Bank Account");
            bsave.Enabled = false;
            //bmodify.Enabled = false;
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

            da3 = new SqlDataAdapter();
            ds3 = new DataSet();
            cmd3 = new SqlCommand();
            cb3 = new SqlCommandBuilder();

            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioDesktopApp\shopmanagement\db\shop.mdf;Integrated Security=True;";
            db.Open();

            cmd.Connection = db;
            cmd1.Connection = db;
            cmd2.Connection = db;
            cmd3.Connection = db;

            cmd.CommandText = "Select * from purchase";
            cmd1.CommandText = "Select * from dmaster";
            cmd2.CommandText = "Select * from pentry";
            cmd3.CommandText = "Select * from amaster";

            da.SelectCommand = cmd;
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "purchase");
            cb.DataAdapter = da;

            da1.SelectCommand = cmd1;
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da1.Fill(ds1, "dmaster");
            cb1.DataAdapter = da1;

            da2.SelectCommand = cmd2;
            da2.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da2.Fill(ds2, "pentry");
            cb2.DataAdapter = da2;

            da3.SelectCommand = cmd3;
            da3.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da3.Fill(ds3, "amaster");
            cb3.DataAdapter = da3;

            cdname.DataSource = ds1.Tables["dmaster"];
            cdname.DisplayMember = "name";

            csku.DataSource = ds2.Tables["pentry"];
            csku.DisplayMember = "sku";

            caccname.DataSource = ds3.Tables["amaster"];
            caccname.DisplayMember = "name";

            listBox1.DataSource = ds.Tables["purchase"];
            listBox1.DisplayMember = "invoice";

        }
    }
}
