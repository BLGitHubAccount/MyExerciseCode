using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoWeather
{
    /// <summary>
    /// 城市基础天气信息类
    /// </summary>
    [Serializable]
    public class CWeather
    {
        [JsonProperty("weatherinfo")]
        public CWeatherInfo WeatherInfo { get; set; }
    }

    [Serializable]
    public class CWeatherInfo
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("cityid")]
        public string CityId { get; set; }

        /// <summary>
        /// 气温1
        /// </summary>
        [JsonProperty("temp1")]
        public string Temp1 { get; set; }

        /// <summary>
        /// 气温2
        /// </summary>
        [JsonProperty("temp2")]
        public string Temp2 { get; set; }

        /// <summary>
        /// 天气情况
        /// </summary>
        [JsonProperty("weather")]
        public string Weather { get; set; }

        [JsonProperty("img1")]
        public string Img1 { get; set; }

        [JsonProperty("img2")]
        public string Img2 { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("ptime")]
        public string PTime { get; set; }

    }

    /// <summary>
    /// 城市基础天气信息类(另外一个)
    /// </summary>
    [Serializable]
    public class DWeather
    {
        [JsonProperty("weatherinfo")]
        public DWeatherInfo WeatherInfo { get; set; }
    }

    [Serializable]
    public class DWeatherInfo {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("cityid")]
        public string CityId { get; set; }

        /// <summary>
        /// 气温1
        /// </summary>
        [JsonProperty("temp")]
        public string Temp { get; set; }

        /// <summary>
        /// 风向
        /// </summary>
        [JsonProperty("WD")]
        public string WD { get; set; }

        /// <summary>
        /// 风速
        /// </summary>
        [JsonProperty("WS")]
        public string WS { get; set; }

        /// <summary>
        /// 相对湿度
        /// </summary>
        [JsonProperty("SD")]
        public string SD { get; set; }

        /// <summary>
        /// 风力
        /// </summary>
        [JsonProperty("WSE")]
        public string WSE { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// 是否有雷达图（1表示有雷达图）
        /// </summary>
        [JsonProperty("isRadar")]
        public string IsRadar { get; set; }

        /// <summary>
        /// 雷达图地址（AZ9532为青岛雷达）
        /// </summary>
        [JsonProperty("Radar")]
        public string Radar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("njd")]
        public string Njd { get; set; }

        [JsonProperty("qy")]
        public string Qy { get; set; }

        [JsonProperty("rain")]
        public string Rain { get; set; }

    }

    /// <summary>
    /// 新浪天气预报API实体类
    /// </summary>
    [Serializable]
    [XmlRoot("Profiles")]
    public class SWeather {

        [JsonProperty("Weather")]
        [XmlElementAttribute("Weather")]
        public SWeatherInfo WeatherInfo { get; set; }
    }

    public class SWeatherInfo {

        /// <summary>
        /// 对应的查询城市
        /// </summary>
        [JsonProperty("city")]
        [XmlElementAttribute("city")]
        public string City { get; set; }

        /// <summary>
        /// 白天天气情况
        /// </summary>
        [JsonProperty("status1")]
        [XmlElementAttribute("status1")]
        public string Status1 { get; set; }

        /// <summary>
        /// 夜间天气情况
        /// </summary>
        [JsonProperty("status2")]
        [XmlElementAttribute("status2")]
        public string Status2 { get; set; }

        /// <summary>
        /// 白天天气情况拼音
        /// </summary>
        [JsonProperty("figure1")]
        [XmlElementAttribute("figure1")]
        public string Figure1 { get; set; }

        /// <summary>
        /// 夜间天气情况拼音
        /// </summary>
        [JsonProperty("figure2")]
        [XmlElementAttribute("figure2")]
        public string Figure2 { get; set; }

        /// <summary>
        /// 白天风向
        /// </summary>
        [JsonProperty("direction1")]
        [XmlElementAttribute("direction1")]
        public string Direction1 { get; set; }

        /// <summary>
        /// 夜晚风向
        /// </summary>
        [JsonProperty("direction2")]
        [XmlElementAttribute("direction2")]
        public string Direction2 { get; set; }

        /// <summary>
        /// 白天风力
        /// </summary>
        [JsonProperty("power1")]
        [XmlElementAttribute("power1")]
        public string Power1 { get; set; }

        /// <summary>
        /// 夜间风力
        /// </summary>
        [JsonProperty("power2")]
        [XmlElementAttribute("power2")]
        public string Power2 { get; set; }

        /// <summary>
        /// 白天温度
        /// </summary>
        [JsonProperty("temperature1")]
        [XmlElementAttribute("temperature1")]
        public string Temperature1 { get; set; }

        /// <summary>
        /// 夜间温度
        /// </summary>
        [JsonProperty("temperature2")]
        [XmlElementAttribute("temperature2")]
        public string Temperature2 { get; set; }

        /// <summary>
        /// 体感指数
        /// </summary>
        [JsonProperty("ssd")]
        [XmlElementAttribute("ssd")]
        public string Ssd { get; set; }

        /// <summary>
        /// 白天体感温度
        /// </summary>
        [JsonProperty("tgd1")]
        [XmlElementAttribute("tgd1")]
        public string Tgd1 { get; set; }

        /// <summary>
        /// 夜间体感温度
        /// </summary>
        [JsonProperty("tgd2")]
        [XmlElementAttribute("tgd2")]
        public string Tgd2 { get; set; }

        /// <summary>
        /// 紫外线强度
        /// </summary>
        [JsonProperty("zwx")]
        [XmlElementAttribute("zwx")]
        public string Zwx { get; set; }

        /// <summary>
        /// 空调指数
        /// </summary>
        [JsonProperty("ktk")]
        [XmlElementAttribute("ktk")]
        public string Ktk { get; set; }

        /// <summary>
        /// 污染指数
        /// </summary>
        [JsonProperty("pollution")]
        [XmlElementAttribute("pollution")]
        public string Pollution { get; set; }

        /// <summary>
        /// 洗车指数
        /// </summary>
        [JsonProperty("xcz")]
        [XmlElementAttribute("xcz")]
        public string Xcz { get; set; }

        /// <summary>
        /// 综合指数这个我不确定
        /// </summary>
        [JsonProperty("zho")]
        [XmlElementAttribute("zho")]
        public string Zho { get; set; }

        /// <summary>
        /// 没猜出来是什么指数，没有数值
        /// </summary>
        [JsonProperty("diy")]
        [XmlElementAttribute("diy")]
        public string Diy { get; set; }

        /// <summary>
        /// 同上
        /// </summary>
        [JsonProperty("fas")]
        [XmlElementAttribute("fas")]
        public string Fas { get; set; }

        /// <summary>
        /// 穿衣指数
        /// </summary>
        [JsonProperty("chy")]
        [XmlElementAttribute("chy")]
        public string Chy { get; set; }

        /// <summary>
        /// zho的说明，然而zho是什么指数我也不确定
        /// </summary>
        [JsonProperty("zho_shuoming")]
        [XmlElementAttribute("zho_shuoming")]
        public string Zho_shuoming { get; set; }

        /// <summary>
        /// 同上
        /// </summary>
        [JsonProperty("diy_shuoming")]
        [XmlElementAttribute("diy_shuoming")]
        public string Diy_shuoming { get; set; }

        /// <summary>
        /// 同上
        /// </summary>
        [JsonProperty("fas_shuoming")]
        [XmlElementAttribute("fas_shuoming")]
        public string Fas_shuoming { get; set; }

        /// <summary>
        /// 穿衣指数说明
        /// </summary>
        [JsonProperty("chy_shuoming")]
        [XmlElementAttribute("chy_shuoming")]
        public string Chy_shuoming { get; set; }

        /// <summary>
        /// 污染程度
        /// </summary>
        [JsonProperty("pollution_l")]
        [XmlElementAttribute("pollution_l")]
        public string Pollution_l { get; set; }

        /// <summary>
        /// 紫外线指数概述
        /// </summary>
        [JsonProperty("zwx_l")]
        [XmlElementAttribute("zwx_l")]
        public string Zwx_l { get; set; }

        /// <summary>
        /// 体感指数概述
        /// </summary>
        [JsonProperty("ssd_l")]
        [XmlElementAttribute("ssd_l")]
        public string Ssd_l { get; set; }

        /// <summary>
        /// 这个不知道
        /// </summary>
        [JsonProperty("fas_l")]
        [XmlElementAttribute("fas_l")]
        public string Fas_l { get; set; }

        /// <summary>
        /// 这个不知道
        /// </summary>
        [JsonProperty("zho_l")]
        [XmlElementAttribute("zho_l")]
        public string Zho_l { get; set; }

        /// <summary>
        /// 穿衣指数概述（可理解为穿衣建议）
        /// </summary>
        [JsonProperty("chy_l")]
        [XmlElementAttribute("chy_l")]
        public string Chy_l { get; set; }

        /// <summary>
        /// 空调指数概述
        /// </summary>
        [JsonProperty("ktk_l")]
        [XmlElementAttribute("ktk_l")]
        public string Ktk_l { get; set; }

        /// <summary>
        /// 洗车指数概述
        /// </summary>
        [JsonProperty("xcz_l")]
        [XmlElementAttribute("xcz_l")]
        public string Xcz_l { get; set; }

        /// <summary>
        /// 这个不知道
        /// </summary>
        [JsonProperty("diy_l")]
        [XmlElementAttribute("diy_l")]
        public string Diy_l { get; set; }

        /// <summary>
        /// 污染指数详细说明
        /// </summary>
        [JsonProperty("pollution_s")]
        [XmlElementAttribute("pollution_s")]
        public string Pollution_s { get; set; }

        /// <summary>
        /// 紫外线详细说明
        /// </summary>
        [JsonProperty("zwx_s")]
        [XmlElementAttribute("zwx_s")]
        public string Zwx_s { get; set; }

        /// <summary>
        /// 体感详细说明
        /// </summary>
        [JsonProperty("ssd_s")]
        [XmlElementAttribute("ssd_s")]
        public string Ssd_s { get; set; }

        /// <summary>
        /// 空调指数详细说明
        /// </summary>
        [JsonProperty("ktk_s")]
        [XmlElementAttribute("ktk_s")]
        public string Ktk_s { get; set; }

        /// <summary>
        /// 洗车详细说明
        /// </summary>
        [JsonProperty("xcz_s")]
        [XmlElementAttribute("xcz_s")]
        public string Xcz_s { get; set; }

        /// <summary>
        /// 感冒指数
        /// </summary>
        [JsonProperty("gm")]
        [XmlElementAttribute("gm")]
        public string Gm { get; set; }

        /// <summary>
        /// 感冒指数概述
        /// </summary>
        [JsonProperty("gm_l")]
        [XmlElementAttribute("gm_l")]
        public string Gm_l { get; set; }

        /// <summary>
        /// 感冒指数详细说明
        /// </summary>
        [JsonProperty("gm_s")]
        [XmlElementAttribute("gm_s")]
        public string Gm_s { get; set; }

        /// <summary>
        /// 运动指数
        /// </summary>
        [JsonProperty("yd")]
        [XmlElementAttribute("yd")]
        public string Yd { get; set; }

        /// <summary>
        /// 运动指数概述
        /// </summary>
        [JsonProperty("yd_l")]
        [XmlElementAttribute("yd_l")]
        public string Yd_l { get; set; }

        /// <summary>
        /// 运动指数详细说明
        /// </summary>
        [JsonProperty("yd_s")]
        [XmlElementAttribute("yd_s")]
        public string Yd_s { get; set; }

        /// <summary>
        /// 天气数据日期
        /// </summary>
        [JsonProperty("savedate_weather")]
        [XmlElementAttribute("savedate_weather")]
        public string Savedate_weather { get; set; }

        /// <summary>
        /// 生活数据日期
        /// </summary>
        [JsonProperty("savedate_life")]
        [XmlElementAttribute("savedate_life")]
        public string Savedate_life { get; set; }

        /// <summary>
        /// 指数数据日期
        /// </summary>
        [JsonProperty("savedate_zhishu")]
        [XmlElementAttribute("savedate_zhishu")]
        public string Savedate_zhishu { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("udatetime")]
        [XmlElementAttribute("udatetime")]
        public string Udatetime { get; set; }

    }
}
