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
        double o = 1.0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VisualBrush vBrush = new VisualBrush(this.button1);
            Rectangle rect = new Rectangle();
            rect.Width = button1.ActualWidth;
            rect.Height = button1.ActualHeight;
            rect.Fill = vBrush;
            rect.Opacity = o;
            o -= 0.02;
            this.stackPanel2.Children.Add(rect);
        }
    }
}
