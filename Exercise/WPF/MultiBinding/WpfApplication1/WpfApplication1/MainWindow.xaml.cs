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
            SetMultiBinding();

        }
        private void SetMultiBinding()
        {
            Binding b1 = new Binding("Text") { Source = this.textBox1 };
            Binding b2 = new Binding("Text") { Source = this.textBox2 };
            Binding b3 = new Binding("Text") { Source = this.textBox3 };
            Binding b4 = new Binding("Text") { Source = this.textBox4 };

            MultiBinding mb = new MultiBinding() { Mode = BindingMode.OneWay };
            mb.Bindings.Add(b1);
            mb.Bindings.Add(b2);
            mb.Bindings.Add(b3);
            mb.Bindings.Add(b4);

            mb.Converter = new LogonMultiBindingConverter();
            this.button1.SetBinding(Button.IsEnabledProperty,mb);
        }
    }
}
