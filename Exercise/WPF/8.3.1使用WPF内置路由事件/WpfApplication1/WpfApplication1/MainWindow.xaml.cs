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
            this.rootGrid.AddHandler(Button.ClickEvent,new RoutedEventHandler(this.ButtonClick));
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as FrameworkElement).Name );
        }

        private void Canvas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.Source as FrameworkElement).Name);
            //e.Handled = true;
        }
    }
}
