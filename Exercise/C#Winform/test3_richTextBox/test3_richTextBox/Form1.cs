using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3_richTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void bulebtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void ks18btn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("楷书",18);
        }

        private void itembtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionFont = new Font("宋体",9);
            richTextBox1.SelectionBullet = false;
        }
    }
}
