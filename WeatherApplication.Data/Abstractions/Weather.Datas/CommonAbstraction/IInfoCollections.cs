using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Models;

namespace WeatherApplication.Data.Abstractions
{
    public interface IInfoCollections
    {

        [JsonProperty("dt")]
         long Dt { get; set; }

        [JsonProperty("main")]
         ForeCastTemperatureIndicator Main { get; set; }

        [JsonProperty("weather")]
         List<Weather> Weather { get; set; }

        [JsonProperty("clouds")]
         Clouds Clouds { get; set; }

        [JsonProperty("wind")]
         Wind Wind { get; set; }

        [JsonProperty("rain")]
         Rain Rain { get; set; }

        [JsonProperty("sys")]
         ForeCastSys Sys { get; set; }

        [JsonProperty("dt_txt")]
         DateTimeOffset DtTxt { get; set; }

    }
}
