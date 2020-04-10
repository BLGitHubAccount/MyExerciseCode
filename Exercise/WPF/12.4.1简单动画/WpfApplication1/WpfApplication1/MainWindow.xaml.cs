﻿using System;
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
            DoubleAnimation daX = new DoubleAnimation();
            DoubleAnimation daY = new DoubleAnimation();
            //指定起点
            daX.From = 0D;
            daY.From = 0D;
            //指定终点
            Random r = new Random();
            daX.To = r.NextDouble() * 300;
            daY.To = r.NextDouble() * 300;
            //指定时长
            Duration duration = new Duration(TimeSpan.FromMilliseconds(1000));
            daX.Duration = duration;
            daY.Duration = duration;
            //动画的主体是Translateform变形，而非Button
            this.tt.BeginAnimation(TranslateTransform.XProperty,daX);
            this.tt.BeginAnimation(TranslateTransform.YProperty, daY);


        }
    }
}
