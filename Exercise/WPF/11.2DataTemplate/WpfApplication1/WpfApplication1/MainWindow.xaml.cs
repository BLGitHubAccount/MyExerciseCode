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
            List<Player> plays = new List<Player>();
            
            Player play1 = new Player() { Name="messi", Age=32, Nation="阿根廷", Club="巴塞罗那" };
            Player play2 = new Player() { Name ="Cluo", Age = 34, Nation = "葡萄牙", Club = "尤文图斯" };
            Player play3 = new Player() { Name = "本泽马", Age = 32, Nation = "法国", Club = "皇马" };
            Player play4 = new Player() { Name = "内马尔", Age = 27, Nation = "巴西", Club = "巴黎" };
            Player play5 = new Player() { Name = "武磊", Age = 28, Nation = "中国", Club = "西班牙人" };
            plays.Add(play1);
            plays.Add(play2);
            plays.Add(play3);
            plays.Add(play4);
            plays.Add(play5);
            listBox1.ItemsSource = plays;
            listBox1.SelectedItem = play1;
        }
    }
}
