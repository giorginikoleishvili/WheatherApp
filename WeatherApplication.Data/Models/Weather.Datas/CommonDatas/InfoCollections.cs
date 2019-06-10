using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions;

namespace WeatherApplication.Data.Models
{
    public class InfoCollections : IInfoCollections
    {
        public long Dt { get;set; }
        public ForeCastTemperatureIndicator Main { get;set; }
        public List<Weather> Weather { get;set; }
        public Clouds Clouds { get;set; }
        public Wind Wind { get;set; }
        public Rain Rain { get;set; }
        public ForeCastSys Sys { get;set; }
        public DateTimeOffset DtTxt { get;set; }
        
    }
}
