using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WpfApplication1.convert
{
    class ScoreToImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string strUri = "";
            if ((int)value<60)
            {
                strUri = string.Format(@"/Image/wong.png");
            
            }
            else
            {
                strUri = string.Format(@"/Image/right.png");
               
            }
            return new BitmapImage(new Uri(strUri, UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
