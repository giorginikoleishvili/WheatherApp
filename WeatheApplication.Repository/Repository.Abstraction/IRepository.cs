using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Data.Models;
using WeatherApplication.Data.Models.DailyWeatherModels;

namespace WeatheApplication.Repository.Repository.Abstraction
{
    public interface IRepository
    {
        ForeCastWeather GetAllWeatherForeCastInformation(string lat, string lon, string choice = "C");
        DailyWeather GetAllDailyWeatherInformation(string lat, string lon, string choice = "C");

        Task<List<string>> GetCoordinatsByName(string cityName);
    }
}
