using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatheApplication.Repository.Repository.Abstraction;
using WeatheApplication.Repository.Repository.Implementation;
using WeatherApplication.Data.Models.DailyWeatherModels;

namespace WeatherApplication.Service.Abstraction
{
    public interface ICurrectDailyWeatherService : IService
    {
        string AddressName();

        string Temperature();

        string Wind();

        DailyWeather CreadBaseDailyWeather(string indicator = "C", string lat = "", string lon = "");



    }
}
