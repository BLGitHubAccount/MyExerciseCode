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
using System.Xml;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ////XmlDocument doc = new XmlDocument();
            ////doc.Load(@"D:\RawData.xml");
            //XmlDataProvider xdp = new XmlDataProvider();
            ////xdp.Document = doc;         
            //xdp.Source = new Uri(@"D:\RawData.xml");
            //xdp.XPath = @"/StudentList/Student";
            //this.listView1.DataContext = xdp;
            //this.listView1.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }
    }
}
