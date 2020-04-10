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
using System.Windows.Media.Animation;
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
            DoubleAnimationUsingKeyFrames dakX = new DoubleAnimationUsingKeyFrames();
            DoubleAnimationUsingKeyFrames dakY = new DoubleAnimationUsingKeyFrames();
            //设置动画总时长
            dakX.Duration = new Duration(TimeSpan.FromMilliseconds(900));
            dakY.Duration = new Duration(TimeSpan.FromMilliseconds(900));
            //创建、添加关键帧
            LinearDoubleKeyFrame x_kf_1 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame x_kf_2 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame x_kf_3 = new LinearDoubleKeyFrame();

            x_kf_1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(300));
            x_kf_1.Value = 200;
            x_kf_2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(600));
            x_kf_2.Value = 0;
            x_kf_3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(900));
            x_kf_3.Value = 200;
            dakX.KeyFrames.Add(x_kf_1);
            dakX.KeyFrames.Add(x_kf_2);
            dakX.KeyFrames.Add(x_kf_3);

            LinearDoubleKeyFrame y_kf_1 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame y_kf_2 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame y_kf_3 = new LinearDoubleKeyFrame();
            y_kf_1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(300));
            y_kf_1.Value = 0;
            y_kf_2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(600));
            y_kf_2.Value = 180;
            y_kf_3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(900));
            y_kf_3.Value = 180;
            dakY.KeyFrames.Add(y_kf_1);
            dakY.KeyFrames.Add(y_kf_2);
            dakY.KeyFrames.Add(y_kf_3);

            this.tt.BeginAnimation(TranslateTransform.XProperty,dakX);
            this.tt.BeginAnimation(TranslateTransform.YProperty,dakY);

        }
    }
}
