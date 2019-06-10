using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions.DailyWeatherAbstractions;

namespace WeatherApplication.Data.Models.DailyWeatherModels
{
    public class DailyTemperatureIndicator : IDailyTemperatureIndicator
    {
        public double Temp {get;set; }
        public double Pressure {get;set; }
        public long Humidity {get;set; }
        public double TempMin {get;set; }
        public double TempMax {get;set; }
        public double SeaLevel {get;set; }
        public double GrndLevel {get;set; }
    }
}
