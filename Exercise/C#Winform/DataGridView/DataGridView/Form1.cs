﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“student1DataSet.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter1.Fill(this.student1DataSet.Student);
            // TODO: 这行代码将数据加载到表“baoziDatabaseDataSet.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.baoziDatabaseDataSet.student);

        }
    }
}
