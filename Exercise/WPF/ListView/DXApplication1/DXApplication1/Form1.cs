using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuItem[] items = { new MenuItem("open"), new MenuItem("close") };
            ContextMenu menu = new ContextMenu(items);


            treeView1.ContextMenu =menu;

            this.button1.ContextMenu = menu;
         

        }

        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            // If the right mouse button was clicked and released,
            // display the shortcut menu assigned to the TreeView. 
            if (e.Button == MouseButtons.Right)
            {
                treeView1.ContextMenu.Show(treeView1, new Point(e.X, e.Y));
            }
        }

    }
}
