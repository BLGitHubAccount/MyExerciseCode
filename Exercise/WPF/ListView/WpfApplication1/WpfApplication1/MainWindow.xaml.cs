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
            List<Student> studentList = new List<Student>();
            Random rd = new Random();
            for (int i = 0; i < 6; i++)
            {
                Student stu = new Student();
                stu.Id = i + 1;
                stu.Name =string.Format("学生{0}",i+1);
                stu.Score = rd.Next(40,100);
                stu.Sex = i % 2 == 0 ? "boy" : "girl";
                stu.Age = 18;
                stu.Judge = "hahahahh";
                studentList.Add(stu);
            }
            lsbStudentList.ItemsSource = studentList;
        }
    }
}
