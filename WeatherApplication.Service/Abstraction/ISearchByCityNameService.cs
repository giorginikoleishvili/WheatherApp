using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Data.Models;
using WeatherApplication.Data.Models.DailyWeatherModels;

namespace WeatherApplication.Service.Abstraction
{
    public interface ISearchByCityNameService : IService
    {
        Task<DailyWeather> SearchCityForDailyWeather(string cityName, string choise = "C");

        Task<ForeCastWeather> SearchCityForForeCastWeather(string cityName, string choise = "C");

    }
}
