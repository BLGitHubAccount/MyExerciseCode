using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWeather
{
    /// <summary>
    /// 国家类
    /// </summary>
    public class Country {

        /// <summary>
        /// id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 国家名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 省份列表
        /// </summary>
        public List<Province> ProvinceList { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }

    /// <summary>
    /// 省份类
    /// </summary>
    public class Province
    {
        /// <summary>
        /// 省份名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 省份ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 城市列表
        /// </summary>
        public List<City> CityList { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }

    /// <summary>
    /// 城市类
    /// </summary>
    public class City {
        
        /// <summary>
        /// 城市名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 城市Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 城市里面的城区列表
        /// </summary>
        public List<Urban> UrbanList { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }

    /// <summary>
    /// 城区，县城
    /// </summary>
    public class Urban {
        
        /// <summary>
        /// 城区名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 城区ID
        /// </summary>
        public string Id { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
