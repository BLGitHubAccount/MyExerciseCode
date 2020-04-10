using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoWeather
{
    /// <summary>
    /// 访问天气API接口
    /// </summary>
    public class WeatherAccess
    {
        /// <summary>
        /// 获取天气站点的信息
        /// </summary>
        /// <typeparam name="T">返回类的信息</typeparam>
        /// <param name="url"><网址/param>
        /// <returns></returns>
        public static T CallWeatherWebSite<T>(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/json";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            string strJson = string.Empty;
            while (true)
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream stream = response.GetResponseStream();
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        strJson = reader.ReadToEnd();
                    }
                    break;
                }
                Thread.Sleep(1000);
            }
            //反序列化信息
            if (!string.IsNullOrEmpty(strJson))
            {
                T t = JsonConvert.DeserializeObject<T>(strJson);
                return t;
            }
            return default(T);
        }

        public static T CallWeatherWebSite2<T>(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/xml";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            string strXml = string.Empty;
            bool flag = false;

            while (true)
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream stream = response.GetResponseStream();
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        strXml = reader.ReadToEnd();
                    }
                    break;
                }
                Thread.Sleep(1000);
            }
            //反序列化信息
            if (!string.IsNullOrEmpty(strXml))
            {
                T t = new XmlHelper<T>().Deserialize2(strXml);
                return t;
            }
            return default(T);
        }
    }
}
