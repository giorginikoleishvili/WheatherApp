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
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatheApplication.Repository.HelperMethods.Implementation;
using WeatheApplication.Repository.Repository.Implementation;
using WeatherApplication.Data.Models;
using WeatherApplication.Data.Models.Coordinats.Datas;
using WeatherApplication.Data.Models.DailyWeatherModels;
using WeatherApplication.Network.Layer;
using WeatherApplication.Network.Layer.Implementation;
using WeatherApplication.Service.Abstraction;
using WeatherApplication.Service.CoordinateManager;
using WeatherApplication.Service.Implementation;

namespace WeatherApplication.Forms
{
    public partial class Form1 : Form
    {


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public ForeCastWeather JsonDeserialize<ForeCastWeather>(string jsonstring)
        {
            return JsonConvert.DeserializeObject<ForeCastWeather>(jsonstring);
        }

        private void Fun()
        {


        }







        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }


}
