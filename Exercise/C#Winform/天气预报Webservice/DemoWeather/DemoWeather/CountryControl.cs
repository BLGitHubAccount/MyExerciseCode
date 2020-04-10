using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWeather
{
    public partial class CountryControl : UserControl
    {
        private Country _country;

        /// <summary>
        /// 事件函数
        /// </summary>
        public EventHandler Go { get; set; }

        /// <summary>
        /// 选择的城区对象
        /// </summary>
        public Urban Urban { get; set; }

        public CountryControl()
        {
            InitializeComponent();
        }

        public void InitConfig()
        {
            string filePath = "country.xml";
            XmlHelper<Country> xmlHelper = new XmlHelper<Country>();
            _country = xmlHelper.Deserialize(filePath);

            //国家配置信息
            if (_country != null)
            {
                this.gbBox.Text = string.Format("{0} 的配置信息", _country.Name);
                this.combProvince.Items.AddRange(_country.ProvinceList.ToArray());
                this.combProvince.SelectedIndex = 0;
            }
        }

        private void combProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            object objItem = this.combProvince.SelectedItem;
            if (objItem != null)
            {
                Province p = objItem as Province;
                this.combCity.Items.Clear();
                this.combCity.Items.AddRange(p.CityList.ToArray());
                this.combCity.SelectedIndex = 0;
            }
        }

        private void combCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            object objItem = this.combCity.SelectedItem;
            if (objItem != null)
            {
                City c = objItem as City;
                this.combUrban.Items.Clear();
                this.combUrban.Items.AddRange(c.UrbanList.ToArray());
                this.combUrban.SelectedIndex = 0;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            object objItem = this.combUrban.SelectedItem;
            if (objItem != null)
            {
                Urban = objItem as Urban;
            }
            if (Go != null)
            {
                Go(sender, e);
            }
        }
    }
}
