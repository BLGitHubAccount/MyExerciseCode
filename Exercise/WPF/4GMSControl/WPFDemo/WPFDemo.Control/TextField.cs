using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFDemo.Control
{
    internal class TextField:System.Windows.Controls.Control
    {
        static TextField()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextField),new FrameworkPropertyMetadata(typeof(TextField)));   
        }



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty = TextBlock.TextProperty.AddOwner(typeof(TextField));




    }
}
