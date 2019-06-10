using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions;

namespace WeatherApplication.Data.Models
{
    public class Clouds : IClouds
    {
        public long All { get;set;   }
    }
}
