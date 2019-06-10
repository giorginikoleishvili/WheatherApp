using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions.Coordinats.Datas;

namespace WeatherApplication.Data.Models.Coordinats.Datas
{
    public class Geometry : IGeometry
    {
        public double Lat { get; set ; }
        public double Lng { get; set ; }
    }
}
