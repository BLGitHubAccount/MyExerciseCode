using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoWeather
{
    public class XmlHelper<T> 
    {
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filePath"></param>
        public void Serialize(T obj, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(fs, obj);
            }
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public T Deserialize(string filePath)
        {
            T t;
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                object obj = serializer.Deserialize(fs);
                t = (T)obj;
            }
            return t;
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public T Deserialize2(string fileContent)
        {
            T t;
            using (StringReader fs = new StringReader(fileContent))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                object obj = serializer.Deserialize(fs);
                t = (T)obj;
            }
            return t;
        }
    }
}
