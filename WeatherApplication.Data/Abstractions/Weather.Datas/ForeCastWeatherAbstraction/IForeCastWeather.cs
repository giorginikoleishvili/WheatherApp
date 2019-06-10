using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions;
using WeatherApplication.Data.Models;

namespace WeatherApplication.Data
{
    public interface IForeCastWeather
    {
        [JsonProperty("Cod")]
        //[JsonConverter(typeof(ParseStringConverter))]
         long Cod { get; set; }

        [JsonProperty("message")]
         double Message { get; set; }

        [JsonProperty("cnt")]
         long Cnt { get; set; }

        [JsonProperty("list")]
         List<InfoCollections> List { get; set; }

        [JsonProperty("city")]
         City City { get; set; }
    }
}
