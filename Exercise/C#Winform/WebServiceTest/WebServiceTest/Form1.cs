using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WebServiceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getcountury();
        }

        private void getcountury()
        {
           ServiceReference1.WeatherWSSoapClient weatherClient = new ServiceReference1.WeatherWSSoapClient("WeatherWSSoap");
           string[] provinces=weatherClient.getRegionProvince();
            foreach (var item in provinces)
            {
                Console.WriteLine(item);
            }
           
        }

    }
}
