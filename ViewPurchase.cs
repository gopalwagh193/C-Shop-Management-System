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
    public partial class ViewPurchase : Form
    {


        SqlConnection db;       //open the database
        SqlDataAdapter da, da1, da2, da3;       //connection table
        DataSet ds, ds1, ds2, ds3;                //access the database

        SqlCommand cmd, cmd2, cmd1, cmd3;    //connection table

        SqlCommandBuilder cb, cb1, cb2, cb3;

        DataRow dr, dr1, dr2, dr3;                    //add data to database



        int count = 0, count1 = 0, keyy;

        public ViewPurchase()
        {
            InitializeComponent();
        }

        private void ViewPurchase_Load(object sender, EventArgs e)
        {

            db = new SqlConnection();
            da = new SqlDataAdapter();
            ds = new DataSet();
            cmd = new SqlCommand();
            cb = new SqlCommandBuilder();

            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioDesktopApp\shopmanagement\db\shop.mdf;Integrated Security=True;";
            db.Open(); //open the connection

            cmd.Connection = db;
            cmd.CommandText = "select * from purchase";

            da.SelectCommand = cmd;
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "purchase"); //dataadapter is filling the data using dataset of student
            cb.DataAdapter = da;

        }

        private void bshow_Click(object sender, EventArgs e)
        {
            griddata.DataSource = ds.Tables["purchase"];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
