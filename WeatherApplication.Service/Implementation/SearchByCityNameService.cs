using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatheApplication.Repository.Repository.Implementation;
using WeatherApplication.Data.Models;
using WeatherApplication.Data.Models.Coordinats.Datas;
using WeatherApplication.Data.Models.DailyWeatherModels;
using WeatherApplication.Service.Abstraction;
using WeatherApplication.Service.ExtentionMethod;

namespace WeatherApplication.Service.Implementation
{
    public class SearchByCityNameService : ISearchByCityNameService
    {
        private Repository _repository = new Repository();
        private CurrentDailyWeatherService _currentDailyWeatherService = new CurrentDailyWeatherService();
        private CurrentForeCastWeatherService _currentForeCastWeatherService = new CurrentForeCastWeatherService();

        public async Task<DailyWeather> SearchCityForDailyWeather(string cityName, string choise = "C")
        {
            var is_NullParametrs = this.CheckToNull(cityName, choise);
            var is_Internet = this.CheckInternetConnection();

            if (is_Internet)
            {
                if (!is_NullParametrs)
                {
                    var coordinatList = await _repository.
                                    GetCoordinatsByName(cityName);

                    var lat = coordinatList.ElementAt(0);
                    var lon = coordinatList.ElementAt(1);

                    return _currentDailyWeatherService.
                        CreadBaseDailyWeather
                        (choise, lat, lon);
                }
                else
                    throw new Exception("Some parametrs are null");
            }
            else
                throw new Exception("No Internet Exeption");
        }

        public async Task<ForeCastWeather> SearchCityForForeCastWeather(string cityName, string choise = "C")
        {
            var is_NullParametrs = this.CheckToNull(cityName, choise);
            var is_Internet = this.CheckInternetConnection();

            if (is_Internet)
            {
                if (!is_NullParametrs)
                {
                    var coordinatList = await _repository.
                    GetCoordinatsByName(cityName);

                    var lat = coordinatList.ElementAt(0);
                    var lon = coordinatList.ElementAt(1);

                    return _currentForeCastWeatherService.
                        GetCurrentForeCastWeather
                        (choise, lat, lon);
                }
                else
                    throw new Exception("Some parametrs are null");
            }
            else
                throw new Exception("No Internet Exeption");

        }

    }
}
