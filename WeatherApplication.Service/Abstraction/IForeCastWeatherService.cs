using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Data.Models;

namespace WeatherApplication.Service.Abstraction
{
    public interface IForeCastWeatherService : IService
    {
        string AddressName();

        List<string> Temperature();

        List<string> Wind();

        List<string> CurrentDates();

        ForeCastWeather GetCurrentForeCastWeather(string indicator = "C", string lat = "", string lon = "");
    }
}
