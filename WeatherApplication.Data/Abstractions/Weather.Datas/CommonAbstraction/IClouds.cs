using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApplication.Data.Abstractions
{
    public interface IClouds
    {
        [JsonProperty("all")]
         long All { get; set; }
    }
}
