using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions;
using static WeatherApplication.Data.Models.Enums;

namespace WeatherApplication.Data.Models
{
    public class ForeCastSys : IForeCastSys
    {
        public Pod Pod { get; set; }
    }

}

