using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions;

namespace WeatherApplication.Data.Models
{
    public class Wind : IWind
    {
        public double Speed { get; set; }
        public double Deg { get;set;}
    }
}
