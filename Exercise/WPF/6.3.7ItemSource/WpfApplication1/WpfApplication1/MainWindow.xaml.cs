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
            List<Student> list = new List<Student>();
            for (int i = 0; i < 3; i++)
            {
                Student stu = new Student();
                stu.Id = i;
                stu.Name = "小明";
                stu.Age = 18;
                list.Add(stu);
            }
            listBox1.ItemsSource = list;
            //listBox1.DisplayMemberPath = "Name";
            Binding binding = new Binding();
            textBox1.SetBinding(TextBox.TextProperty, new Binding("SelectedItem.Id") { Source=listBox1});
            
        }
    }
}
