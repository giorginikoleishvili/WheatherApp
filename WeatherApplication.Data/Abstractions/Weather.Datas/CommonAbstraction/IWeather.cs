using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static WeatherApplication.Data.Models.Enums;

namespace WeatherApplication.Data.Abstractions
{
    public interface IWeather
    {
        [JsonProperty("id")]
         long Id { get; set; }

        [JsonProperty("main")]
         MainEnum Main { get; set; }

        [JsonProperty("description")]
         string  Description { get; set; }

        [JsonProperty("icon")]
        string Icon { get; set; }
    }   
}
