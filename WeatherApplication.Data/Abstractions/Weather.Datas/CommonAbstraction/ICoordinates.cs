using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApplication.Data.Abstractions
{
    public  interface ICoordinates
    {
        [JsonProperty("lat")]
         double Lat { get; set; }

        [JsonProperty("lon")]
         double Lon { get; set; }
    }
}
