using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Models;
using WeatherApplication.Data.Models.DailyWeatherModels;

namespace WeatherApplication.Data.Abstractions.DailyWeatherAbstractions
{
     interface IDailyWeather
    {

        [JsonProperty("coord")]
         Coordinate Coord { get; set; }

        [JsonProperty("weather")]
         List<Weather> Weather { get; set; }

        [JsonProperty("base")]
         string Base { get; set; }

        [JsonProperty("main")]
         DailyTemperatureIndicator Main { get; set; }

        [JsonProperty("wind")]
         Wind Wind { get; set; }

        [JsonProperty("clouds")]
         Clouds Clouds { get; set; }

        [JsonProperty("dt")]
         long Dt { get; set; }

        [JsonProperty("sys")]
         DailySys Sys { get; set; }

        [JsonProperty("id")]
         long Id { get; set; }

        [JsonProperty("name")]
         string Name { get; set; }

        [JsonProperty("cod")]
         long Cod { get; set; }
    }
}
