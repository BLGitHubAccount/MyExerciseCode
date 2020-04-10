using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
{
  public  class TimeButton:Button
    {
        //声明和注册路由事件
        public static readonly RoutedEvent ReportTimeEvent = EventManager.RegisterRoutedEvent("ReportTime",RoutingStrategy.Bubble,typeof(EventHandler<ReportTimeEventArgs>),typeof(TimeButton));
        //CLR包装器
        public event RoutedEventHandler ReportTime
        {
            add { this.AddHandler(ReportTimeEvent,value); }
            remove { this.RemoveHandler(ReportTimeEvent,value); }
        }
        //激发路由事件，使用click事件的激发方法
        protected override void OnClick()
        {
            base.OnClick();//保证Button原有功能正常使用，click事件能激发
            ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent,this);
            args.ClickTime = DateTime.Now;
            this.RaiseEvent(args);
        }
    }
}
