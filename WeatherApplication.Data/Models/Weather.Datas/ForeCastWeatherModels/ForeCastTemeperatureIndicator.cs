using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions;

namespace WeatherApplication.Data.Models
{
    public class ForeCastTemperatureIndicator  : IForeCastTemperatureIndicator  // Main
    {
        public double Temp {get;set; }
        public double TempMin {get;set; }
        public double TempMax {get;set; }
        public double Pressure {get;set; }
        public double SeaLevel {get;set; }
        public double GrndLevel {get;set; }
        public long Humidity {get;set; }
        public long TempKf {get;set; }
    }
}
