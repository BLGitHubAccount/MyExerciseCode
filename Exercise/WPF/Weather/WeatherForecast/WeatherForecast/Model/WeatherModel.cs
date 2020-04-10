using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Model
{
   public class WeatherModel: INotifyPropertyChanged
    {

        private int _cityCode;

        public int CityCode
        {
            get { return _cityCode; }
            set
            {
               _cityCode = value;
                PropertyChangedEvent("CityCode");
             }
        }

        private int _cityName;

        public int CityName
        {
            get { return _cityName; }
            set
            {
                _cityName = value;
                PropertyChangedEvent("CityName");
            }
        }

        private TodayWeatherInfo _todayWeather;

        public TodayWeatherInfo TodayWeather
        {
            get { return _todayWeather; }
            set
            {
                _todayWeather = value;
                PropertyChangedEvent("TodayWeather");
            }
        }

        private WeatherTrendsInfo _weatherTrends;

        public WeatherTrendsInfo WeatherTrends
        {
            get { return _weatherTrends; }
            set
            {
                _weatherTrends = value;
                PropertyChangedEvent("WeatherTrends");
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
