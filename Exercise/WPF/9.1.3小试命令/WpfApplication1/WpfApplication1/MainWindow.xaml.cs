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
            InitializeCommand();
        }

        private RoutedCommand clearCmd = new RoutedCommand("clear",typeof(MainWindow));

        private void InitializeCommand()
        {
            //把命令赋值给命令源（发送者）并指定快捷键
            this.button1.Command = this.clearCmd;
            this.clearCmd.InputGestures.Add(new KeyGesture(Key.C,ModifierKeys.Alt));
            //指定命令目标
            this.button1.CommandTarget = this.textBox1;
            //创建命令关联
            CommandBinding cb = new CommandBinding();
            cb.Command = this.clearCmd;
            cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExcute);
            cb.Executed += new ExecutedRoutedEventHandler(cb_Excute);

            //把命令关联安置在外围控件上
            this.stackpanel1.CommandBindings.Add(cb);
        }


        private void cb_Excute(object sender, ExecutedRoutedEventArgs e)
        {
            this.textBox1.Clear();
            e.Handled = true;
        }

        private void cb_CanExcute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            //避免继续上传降低程序性能
            e.Handled = true;
        }
    }
}
