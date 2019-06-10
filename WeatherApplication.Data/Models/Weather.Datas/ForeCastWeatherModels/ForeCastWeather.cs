using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions;

namespace WeatherApplication.Data.Models
{
    public class ForeCastWeather : IForeCastWeather     //Temperature (Welcome)
    {
        public long Cod { get;set;}
        public double Message { get;set;}
        public long Cnt { get;set;}
        public List<InfoCollections> List { get;set;}
        public City City { get;set;}
    }

}
