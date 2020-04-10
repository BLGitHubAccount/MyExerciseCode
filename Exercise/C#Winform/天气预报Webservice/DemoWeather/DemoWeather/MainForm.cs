using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWeather
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChinaWeather_Click(object sender, EventArgs e)
        {
            ChinaMainForm c = new ChinaMainForm();
            c.ShowDialog();

        }

        private void btnSinaWeather_Click(object sender, EventArgs e)
        {
            SinaMainForm s = new SinaMainForm();
            s.ShowDialog();
        }
    }
}
