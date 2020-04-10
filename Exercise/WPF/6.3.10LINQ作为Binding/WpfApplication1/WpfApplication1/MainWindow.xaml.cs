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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Student> stuList = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                Student stu = new Student();
                stu.Id = i;
                stu.Name = "Messi";
                stu.Age = 17;
                stuList.Add(stu);
            }
            stuList.Add(new Student() {Id=1, Name="C罗", Age=18});

            //listView1.ItemsSource = from o in stuList where o.Name.StartsWith("M")select o;
            listView1.ItemsSource = stuList.Where<Student>(o=>o.Name=="C罗").ToList();

        }
    }
}
