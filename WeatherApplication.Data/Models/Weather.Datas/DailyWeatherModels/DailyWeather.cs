using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions.DailyWeatherAbstractions;

namespace WeatherApplication.Data.Models.DailyWeatherModels
{
    public class DailyWeather : IDailyWeather
    {
        public Coordinate Coord { get;set; }
        public List<Weather> Weather { get;set; }
        public string Base { get;set; }
        public DailyTemperatureIndicator Main { get;set; }
        public Wind Wind { get;set; }
        public Clouds Clouds { get;set; }
        public long Dt { get;set; }
        public DailySys Sys { get;set; }
        public long Id { get;set; }
        public string Name { get;set; }
        public long Cod { get;set; }
    }
}
