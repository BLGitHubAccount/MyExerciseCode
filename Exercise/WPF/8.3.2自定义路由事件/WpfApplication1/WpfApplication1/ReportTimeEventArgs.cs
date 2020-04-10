using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1
{
   public class ReportTimeEventArgs:RoutedEventArgs
    {
        public ReportTimeEventArgs(RoutedEvent routeEvent,object source):base(routeEvent, source)
        {

        }
        public DateTime ClickTime { get; set; }
    }
}
