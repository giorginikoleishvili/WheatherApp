using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Models.Coordinats.Datas;

namespace WeatherApplication.Data.Abstractions.Coordinats.Datas
{
    public interface IResult
    {

        [JsonProperty("geometry")]
        Geometry Geometry { get; set; }
    }
}
