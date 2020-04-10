using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Model
{
    public class TodayWeatherInfo : INotifyPropertyChanged
    {
        private int _updateTime;

        public int UpdateTime
        {
            get { return _updateTime; }
            set
            {
                _updateTime = value;
                PropertyChangedEvent("UpdateTime");
            }
        }

        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                PropertyChangedEvent("Temperature");
            }
        }

        private ObservableCollection<string> _lifeList;

        public ObservableCollection<string> LifeList
        {
            get { return _lifeList; }
            set
            {
                _lifeList = value;
                PropertyChangedEvent("LifeList");
            }
        }

        private string _cityIntroduction;

        public string CityIntroduction
        {
            get { return _cityIntroduction; }
            set
            {
                _cityIntroduction = value;
                PropertyChangedEvent("CityIntroduction");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void PropertyChangedEvent(object PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(null, new PropertyChangedEventArgs(PropertyName.ToString()));
            }
        }
    }
}
