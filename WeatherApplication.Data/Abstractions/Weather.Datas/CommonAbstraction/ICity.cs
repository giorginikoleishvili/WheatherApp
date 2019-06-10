using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Models;

namespace WeatherApplication.Data.Abstractions
{
    interface ICity
    {
        [JsonProperty("id")]
         long Id { get; set; }

        [JsonProperty("name")]
         string Name { get; set; }

        [JsonProperty("coord")]
         Coordinate Coord { get; set; }

        [JsonProperty("country")]
         string Country { get; set; }
    }
}
