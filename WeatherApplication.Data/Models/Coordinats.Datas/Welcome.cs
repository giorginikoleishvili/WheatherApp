using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Abstractions.Coordinats.Datas;

namespace WeatherApplication.Data.Models.Coordinats.Datas
{
    public class Welcome : IWelcome
    {
        public List<Result> Results { get ; set ; }
    }
}
