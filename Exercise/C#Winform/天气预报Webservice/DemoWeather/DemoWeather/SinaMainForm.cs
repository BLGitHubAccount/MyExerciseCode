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
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DemoWeather
{
    public partial class SinaMainForm : Form
    {

        public SinaMainForm()
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
            this.lblWD.Text = "";
            this.lblWSE.Text = "";
            this.lblChy.Text = "";
            this.lblGm.Text = "";
            this.lblPollution.Text = "";
            this.lblYd.Text = "";
            this.lblZwx.Text = "";
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
                string url = string.Format("http://php.weather.sina.com.cn/xml.php?city={0}&password=DJOYnieT8234jlsK&day=0", HttpUtility.UrlEncode(u.Name,Encoding.Default));
                SWeather w = WeatherAccess.CallWeatherWebSite2<SWeather>(url);
                if (w != null)
                {
                    this.lblCity.Text = string.Format("{0}:{1} 转 {2}", w.WeatherInfo.City, w.WeatherInfo.Status1,w.WeatherInfo.Status2);
                    this.pBox1.Image = Image.FromFile(string.Format(@"icon\sina\weather_{0}.png", w.WeatherInfo.Figure1));
                    this.pBox2.Image = Image.FromFile(string.Format(@"icon\sina\weather_{0}b.png", w.WeatherInfo.Figure2));

                    this.lblTemp1.Text = w.WeatherInfo.Temperature1 + "℃";
                    this.lblTemp2.Text = w.WeatherInfo.Temperature2 + "℃";
                    this.lblWD.Text = string.Format("白:{0} 晚:{1}", w.WeatherInfo.Direction1, w.WeatherInfo.Direction2);//风向
                    this.lblWSE.Text = string.Format("白:{0} 晚:{1}", w.WeatherInfo.Power1, w.WeatherInfo.Power2);//风力
                    this.lblChy.Text = string.Format("指数:{0} 描述:{1}", w.WeatherInfo.Chy, w.WeatherInfo.Chy_l);
                    this.lblGm.Text = string.Format("指数:{0} 描述:{1}", w.WeatherInfo.Gm, w.WeatherInfo.Gm_l);
                    this.lblPollution.Text = string.Format("指数:{0} 描述:{1}", w.WeatherInfo.Pollution, w.WeatherInfo.Pollution_l);
                    this.lblYd.Text = string.Format("指数:{0} 描述:{1}", w.WeatherInfo.Yd, w.WeatherInfo.Yd_l);
                    this.lblZwx.Text = string.Format("指数:{0} 描述:{1}", w.WeatherInfo.Zwx, w.WeatherInfo.Zwx_l);
                }
            }

        }
    }
}
