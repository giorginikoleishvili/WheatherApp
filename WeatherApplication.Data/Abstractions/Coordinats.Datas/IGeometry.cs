using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApplication.Data.Abstractions.Coordinats.Datas
{
    public interface IGeometry
    {
        [JsonProperty("lat")]
        double Lat { get; set; }

        [JsonProperty("lng")]
        double Lng { get; set; }
    }
}
