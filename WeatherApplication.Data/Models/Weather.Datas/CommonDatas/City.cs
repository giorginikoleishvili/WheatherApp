using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions;

namespace WeatherApplication.Data.Models
{
    public class City : ICity
    {
        public long Id {get;set; }
        public string Name {get;set; }
        public Coordinate Coord {get;set; }
        public string Country {get;set; }
    }
}
