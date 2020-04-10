using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.InitialCombobox();
        }

        private void InitialCombobox()
        {
            DataTable table = new DataTable();
            DataColumn column;
            DataRow row;

            column = new DataColumn("Name");
            table.Columns.Add(column);

            column = new DataColumn("Value");
            table.Columns.Add(column);

            for (int i = 0; i < 5; i++)
            {
                row = table.NewRow();
                row["Name"] = "Test" + i;
                row["Value"] = i.ToString();
                table.Rows.Add(row);
            }

            this.comboBox1.DataSource = table;

            
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Value";
        }

  

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.textBox1.Text = this.comboBox1.SelectedValue.ToString();
        }
    }
}
