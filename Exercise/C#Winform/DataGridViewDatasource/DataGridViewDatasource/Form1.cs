﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DataGridViewDatasource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bdGridView.DataSource = bangdingDatasource().Tables[0];
        }

        private static DataSet bangdingDatasource()
        {
            string constr = "server=.;user=sa;pwd=baolj;database=student1";
            SqlConnection mycon = new SqlConnection(constr);
            string sql = "select * from student";
            SqlDataAdapter myda = new SqlDataAdapter(sql, mycon);
            DataSet ds = new DataSet();
            //  MessageBox.Show("连接数据库成功");
            try
            {
                mycon.Open();           
                myda.Fill(ds, "student");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycon.Close();
                
            }
            return ds;

        }
    }
}
