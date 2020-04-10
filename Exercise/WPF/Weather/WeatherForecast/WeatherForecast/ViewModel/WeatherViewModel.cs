using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WeatherForecast.Model;
using System.Windows.Input;
using WeatherForecast.Command;

namespace WeatherForecast.ViewModel
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
       
        public WeatherViewModel()
        {
            InquireCommand = new InquireCommand(ExcuteInquire, CanExcute);

              ProinceList = WeatherHelper.GetProvinceList();
              SelectProvince = ProinceList.FirstOrDefault();
              CityList= WeatherHelper.GetCityList(SelectProvince.Code);
              SelectCity = CityList.FirstOrDefault();
        }



        private ObservableCollection<ProvinceInfo> _provinceList;

        public ObservableCollection<ProvinceInfo> ProinceList
        {
            get { return _provinceList; }
            set
            {
                _provinceList = value;
                PropertyChangedEvent("ProinceList");
            }
        }

        private ProvinceInfo _selectProvince;

        public ProvinceInfo SelectProvince
        {
            get { return _selectProvince; }
            set
            {
                _selectProvince = value;
                PropertyChangedEvent("SelectProvince");
            }
        }

        private ObservableCollection<CityInfo> _cityList;

        public ObservableCollection<CityInfo> CityList
        {
            get { return _cityList; }
            set
            {
                _cityList = value;
                PropertyChangedEvent("CityList");
            }
        }

        private CityInfo _selectCity;

        public CityInfo SelectCity
        {
            get { return _selectCity; }
            set
            {
                _selectCity = value;
                PropertyChangedEvent("SelectCity");
            }
        }

        public WeatherModel WeatherModel { get; set; }

        public ICommand InquireCommand { get; set; }

        private void ExcuteInquire(object param)
        {
            ProvinceInfo info = param as ProvinceInfo;
            CityList= WeatherHelper.GetCityList(info.Code);

        }

        private bool CanExcute(object param)
        {
            return true;
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
