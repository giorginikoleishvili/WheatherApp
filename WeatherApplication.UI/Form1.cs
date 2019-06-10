using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatheApplication.Repository.Repository.Implementation;
using WeatherApplication.Data.Models.Coordinats.Datas;
using WeatherApplication.Network.Layer;
using WeatherApplication.Network.Layer.Abstraction;
using WeatherApplication.Network.Layer.Implementation;
using WeatherApplication.Service.Abstraction;
using WeatherApplication.Service.HelperMethod;
using WeatherApplication.Service.Implementation;

namespace WeatherApplication.UI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected async override void OnLoad(EventArgs e)
        {
            InstanceActivator instanceActivator = new InstanceActivator();

            var b = instanceActivator.InjectAndGetObject<GetImageUrlService>(typeof(GetImageUrlService)).Compile().Invoke();
            b.GeneratingUrlForImage(// ააქ უნდა გადავცეეე ფოტოს ID)
            


        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
