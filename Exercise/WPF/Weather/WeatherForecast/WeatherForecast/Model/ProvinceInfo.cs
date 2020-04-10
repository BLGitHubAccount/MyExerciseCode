using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    public class ProvinceInfo : INotifyPropertyChanged
    {
        public ProvinceInfo(string name,string code)
        {
            this.Name = name;
            this.Code = code;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                PropertyChangedEvent("Name");
            }
        }

        private string _code;

        public string Code
        {
            get { return _code; }
            set
            {
                _code = value;
                PropertyChangedEvent("Code");
            }
        }


        private void PropertyChangedEvent(object PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(null, new PropertyChangedEventArgs(PropertyName.ToString()));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
