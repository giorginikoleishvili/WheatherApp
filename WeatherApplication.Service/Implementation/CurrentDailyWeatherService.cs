using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatheApplication.Repository.Repository.Abstraction;
using WeatheApplication.Repository.Repository.Implementation;
using WeatherApplication.Data.Models.DailyWeatherModels;
using WeatherApplication.Service.Abstraction;
using WeatherApplication.Service.CoordinateManager;
using WeatherApplication.Service.ExtentionMethod;
using WeatherApplication.Service.HelperMethod;

namespace WeatherApplication.Service.Implementation
{
    public class CurrentDailyWeatherService : ICurrectDailyWeatherService
    {
        private IRepository _repository = new Repository();
        private Coordinates _coordinate = new Coordinates();
        public DailyWeather _mainDailyObject = null;

        
        public CurrentDailyWeatherService()
        {
            CreadBaseDailyWeather();
        }
        public string AddressName()
        {
            return _mainDailyObject.Name;
        }

        public string Temperature()
        {
            return _mainDailyObject.Main.Temp.ToString();
        }

        public string GetPhotoId()
        {
            var a =  _mainDailyObject.Weather;
            
        }

        public string Wind()
        {
            return _mainDailyObject.Wind.Speed.ToString();
        }

        public DailyWeather CreadBaseDailyWeather(string indicator = "C", string lat = "", string lon ="")
        {
            var is_ParametrsNull = this.CheckToNull(indicator, lat, lon);
            var is_Internet = this.CheckInternetConnection();

            if (is_Internet)
            {
                if (!is_ParametrsNull)
                {
                    _coordinate.FindCooordinates(lat, lon);
                    var currentLatitude = _coordinate.Latidude;
                    var currentLontitude = _coordinate.Longtitude;

                    var currentDailyWeatherInformation = _repository.
                        GetAllDailyWeatherInformation
                        (currentLatitude, currentLontitude, indicator);

                    _mainDailyObject = currentDailyWeatherInformation;

                    return _mainDailyObject;
                }
                else
                    throw new Exception("Some parametrs are null");
            }
            else
                throw new Exception("No internet exeption");
        }

        


        


    }
}
