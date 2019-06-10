using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions.Coordinats.Datas;

namespace WeatherApplication.Data.Models.Coordinats.Datas
{
    public class Result : IResult
    {
        public Geometry Geometry { get; set; }
    }
}
