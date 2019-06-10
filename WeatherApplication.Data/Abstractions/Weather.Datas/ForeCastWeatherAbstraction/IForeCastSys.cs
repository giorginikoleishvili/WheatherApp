using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static WeatherApplication.Data.Models.Enums;

namespace WeatherApplication.Data.Abstractions
{
    public interface IForeCastSys
    {
        [JsonProperty("pod")]
         Pod Pod { get; set; }
    }
}
