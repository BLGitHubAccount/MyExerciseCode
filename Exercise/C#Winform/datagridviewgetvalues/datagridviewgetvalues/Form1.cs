using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridviewgetvalues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“baoziDatabaseDataSet.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.baoziDatabaseDataSet.student);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //第1种方法
            //int row = e.RowIndex + 1, col = e.ColumnIndex + 1;
            //第2种方法
            //int row = dataGridView1.CurrentCell.RowIndex + 1,col=dataGridView1.CurrentCell.ColumnIndex+1;
            //第3种方法
            int row = dataGridView1.CurrentCellAddress.Y + 1, col = dataGridView1.CurrentCellAddress.X + 1;

            //string Val = dataGridView1.Rows[row-1].Cells[col-1].Value.ToString();
            string Val = dataGridView1.CurrentCell.Value.ToString();
            MessageBox.Show("你点击的是第"+row.ToString()+"行,第"+col.ToString()+"列\n内容是："+Val);


        }
    }
}
