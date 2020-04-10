using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_ReportTime(object sender, ReportTimeEventArgs e)
        {
            FrameworkElement el = sender as FrameworkElement;
            string timeStr = e.ClickTime.ToLongTimeString();
            string content = string.Format("{0}到达{1}",timeStr,el.Name);
            this.listBox1.Items.Add(content);
        }
    }
}
