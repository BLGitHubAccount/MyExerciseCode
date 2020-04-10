using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Model;

namespace WeatherForecast
{
   public class WeatherHelper
    {

        public static ObservableCollection<ProvinceInfo> GetProvinceList()
        {
            ServiceReference1.WeatherWSSoapClient weatherClient;
            weatherClient = new ServiceReference1.WeatherWSSoapClient("WeatherWSSoap");

            ObservableCollection<ProvinceInfo> list = new ObservableCollection<ProvinceInfo>();
            string[] array = weatherClient.getRegionProvince();
            foreach (var item in array)
            {
                string[] str = item.Split(',');
                ProvinceInfo info = new ProvinceInfo(str[0], str[1]);
                list.Add(info);
            }
            return list;
        }

        public static ObservableCollection<CityInfo> GetCityList(string regionName)
        {
            ServiceReference1.WeatherWSSoapClient weatherClient;
            weatherClient = new ServiceReference1.WeatherWSSoapClient("WeatherWSSoap");
            ObservableCollection<CityInfo> list = new ObservableCollection<CityInfo>();
            string[] array = weatherClient.getSupportCityString(regionName);
            foreach (var item in array)
            {
                string[] str = item.Split(',');
                CityInfo info = new CityInfo(str[0], str[1]);
                list.Add(info);
            }
            return list;
        }
    }
}
