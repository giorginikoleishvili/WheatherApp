using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions;

namespace WeatherApplication.Data.Models
{
    public class Coordinate : ICoordinates
    {
        public double Lat { get;set; }
        public double Lon { get;set; }
    }
}
