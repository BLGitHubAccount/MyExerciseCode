using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WeatherForecast.Model
{
    public class WeatherTrendsInfo : INotifyPropertyChanged
    {

        ObservableCollection<string> _dateList;
        ObservableCollection<string> DateList
        {
            get { return _dateList; }
            set
            {
                _dateList = value;
                PropertyChangedEvent("DateList");
            }
        }

        ObservableCollection<string> _temperatureList;
        ObservableCollection<string> TemperatureList
        {
            get { return _temperatureList; }
            set
            {
                _temperatureList = value;
                PropertyChangedEvent("TemperatureList");
            }
        }

        ObservableCollection<string> _overviewList;
        ObservableCollection<string> OverviewList
        {
            get { return _overviewList; }
            set
            {
                _overviewList = value;
                PropertyChangedEvent("OverviewList");
            }
        }

        ObservableCollection<string> _windDirectionList;
        ObservableCollection<string> WindDirectionList
        {
            get { return _windDirectionList; }
            set
            {
                _windDirectionList = value;
                PropertyChangedEvent("WindDirectionList");
            }
        }

        ObservableCollection<string> _trendList;
        ObservableCollection<string> TrendList
        {
            get { return _trendList; }
            set
            {
                _trendList = value;
                PropertyChangedEvent("TrendList");
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
