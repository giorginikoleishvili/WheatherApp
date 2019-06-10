using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApplication.Data.Abstractions.DailyWeatherAbstractions
{
    public interface IDailySys
    {
        [JsonProperty("message")]
         double Message { get; set; }

        [JsonProperty("country")]
         string Country { get; set; }

        [JsonProperty("sunrise")]
         long Sunrise { get; set; }

        [JsonProperty("sunset")]
         long Sunset { get; set; }
    }
}
