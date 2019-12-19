﻿using System;
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
    public partial class ViewDistributorMaster : Form
    {
        SqlConnection db;//open the database
        SqlDataAdapter da;//connection table 
        DataSet ds;//access the database
        SqlCommand cmd;//connection table
        SqlCommandBuilder cb;//connection table
        DataRow dr;//add the data to database

        int count = 0, keyy;

        public ViewDistributorMaster()
        {
            InitializeComponent();
            this.ActiveControl = bshow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bshow_Click(object sender, EventArgs e)
        {
            griddata.DataSource = ds.Tables["dmaster"];

        }

        private void ViewDistributorMaster_Load(object sender, EventArgs e)
        {
            db = new SqlConnection();
            da = new SqlDataAdapter();
            ds = new DataSet();
            cmd = new SqlCommand();
            cb = new SqlCommandBuilder();

            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioDesktopApp\shopmanagement\db\shop.mdf;Integrated Security=True;";
            db.Open(); //open the connection

            cmd.Connection = db;
            cmd.CommandText = "select * from dmaster";

            da.SelectCommand = cmd;
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "dmaster"); //dataadapter is filling the data using dataset of student
            cb.DataAdapter = da;

        }
    }
}
