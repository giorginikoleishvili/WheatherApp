using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions;
using static WeatherApplication.Data.Models.Enums;

namespace WeatherApplication.Data.Models
{
    public class Weather : IWeather
    {
        public long Id {get;set; }
        public MainEnum Main {get;set; }
        public string Description {get;set; }
        public string Icon {get;set; }
    }
}
