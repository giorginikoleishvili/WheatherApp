using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions.DailyWeatherAbstractions;

namespace WeatherApplication.Data.Models.DailyWeatherModels
{
    public class DailySys : IDailySys
    {
        public double Message {get;set; }
        public string Country {get;set; }
        public long Sunrise {get;set; }
        public long Sunset {get;set; }
    }
}
