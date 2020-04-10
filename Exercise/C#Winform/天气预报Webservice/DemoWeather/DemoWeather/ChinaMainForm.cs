using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DemoWeather
{
    public partial class ChinaMainForm : Form
    {

        public ChinaMainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.countryControl1.InitConfig();
            //绑定事件
            this.countryControl1.Go += new EventHandler(btnGo_Click);
            //
            this.lblCity.Text = "";
            this.lblTemp1.Text = "";
            this.lblTemp2.Text = "";
            this.lblNjd.Text = "";
            this.lblSD.Text = "";
            this.lblTemp.Text = "";
            this.lblWD.Text = "";
            this.lblWS.Text = "";
            this.lblWSE.Text = "";
        }

        /// <summary>
        /// 访问网址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            Urban u = this.countryControl1.Urban;
            if (u != null)
            {
                string url = string.Format("http://www.weather.com.cn/data/cityinfo/{0}.html", u.Id);
                CWeather w = WeatherAccess.CallWeatherWebSite<CWeather>(url);
                url = string.Format("http://www.weather.com.cn/data/sk/{0}.html", u.Id);
                DWeather d = WeatherAccess.CallWeatherWebSite<DWeather>(url);
                if (w != null)
                {
                    this.lblCity.Text = string.Format("{0}:{1}", w.WeatherInfo.City, w.WeatherInfo.Weather);
                    //this.pBox1.Image = Image.FromFile(string.Format(@"icon\day\{0}.png",w.WeatherInfo.Img1.Replace(".gif","").Substring(1).PadLeft(2,'0')));
                    //this.pBox2.Image = Image.FromFile(string.Format(@"icon\night\{0}.png", w.WeatherInfo.Img2.Replace(".gif", "").Substring(1).PadLeft(2, '0')));
                    this.pBox1.Load(string.Format(@"http://m.weather.com.cn/img/{0}", w.WeatherInfo.Img1));
                    this.pBox2.Load(string.Format(@"http://m.weather.com.cn/img/{0}", w.WeatherInfo.Img2));
                    this.lblTemp1.Text = w.WeatherInfo.Temp1;
                    this.lblTemp2.Text = w.WeatherInfo.Temp2;
                }
                if (d != null)
                {
                    this.lblTemp.Text = d.WeatherInfo.Temp + "℃";
                    this.lblSD.Text = d.WeatherInfo.SD;
                    this.lblNjd.Text = d.WeatherInfo.Njd;
                    this.lblWD.Text = d.WeatherInfo.WD;
                    this.lblWS.Text = d.WeatherInfo.WS;
                    this.lblWSE.Text = d.WeatherInfo.WSE;
                }
            }

        }
    }
}
