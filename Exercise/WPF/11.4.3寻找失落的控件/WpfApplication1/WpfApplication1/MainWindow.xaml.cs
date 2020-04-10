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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = this.uc.Template.FindName("textBox1", uc) as TextBox;
            tb.Text="Hello WPF";
            StackPanel sp = this.uc.Template.FindName("stackpanel", uc) as StackPanel;
            TextBox ctb1 = sp.Children[1] as TextBox;
            TextBox ctb2 = sp.Children[2] as TextBox;
            ctb1.Text = "Hello tb1";
            ctb2.Text = "Hello tb2";
        }
    }
}
