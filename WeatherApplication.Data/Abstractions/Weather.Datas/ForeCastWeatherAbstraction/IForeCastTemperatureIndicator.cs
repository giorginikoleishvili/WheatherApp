﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApplication.Data.Abstractions
{
     interface IForeCastTemperatureIndicator
     {
        [JsonProperty("temp")]
         double Temp { get; set; }

        [JsonProperty("temp_min")]
         double TempMin { get; set; }

        [JsonProperty("temp_max")]
         double TempMax { get; set; }

        [JsonProperty("pressure")]
         double Pressure { get; set; }

        [JsonProperty("sea_level")]
         double SeaLevel { get; set; }

        [JsonProperty("grnd_level")]
         double GrndLevel { get; set; }

        [JsonProperty("humidity")]
         long Humidity { get; set; }

        [JsonProperty("temp_kf")]
         long TempKf { get; set; }
    }
}
