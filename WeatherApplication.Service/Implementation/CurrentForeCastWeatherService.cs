using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatheApplication.Repository.Repository.Abstraction;
using WeatheApplication.Repository.Repository.Implementation;
using WeatherApplication.Data.Models;
using WeatherApplication.Service.Abstraction;
using WeatherApplication.Service.CoordinateManager;
using WeatherApplication.Service.ExtentionMethod;

namespace WeatherApplication.Service.Implementation
{
    public class CurrentForeCastWeatherService : IForeCastWeatherService
    {
        private IRepository _repository = new Repository();
        private Coordinates _coordinate = new Coordinates();
        private ForeCastWeather _mainForeCastObject = new ForeCastWeather();
        
        public string AddressName()
        {
            return _mainForeCastObject.City.Name;
        }

        public List<string> CurrentDates()
        {
            return _mainForeCastObject.List.Select(o => o.
                                    DtTxt.
                                    ToString()).
                                    ToList();
        }   

        public List<string> Temperature()
        {
            return _mainForeCastObject.List.Select(o => o.
                                    Main.
                                    Temp.
                                    ToString()).
                                    ToList();
        }

        public List<string> Wind()
        {
           return  _mainForeCastObject.List.Select(o => o.
                                    Wind.
                                    Speed.
                                    ToString()).
                                    ToList();
        }

        public ForeCastWeather GetCurrentForeCastWeather(string indicator ="C", string lat = "", string lon = "")
        {
            var is_parametrsNull = this.CheckToNull(indicator, lat, lon);
            var is_Internet = this.CheckInternetConnection();

            if (is_Internet)
            {
                if (!is_parametrsNull)
                {
                    _coordinate.FindCooordinates(lat, lon);
                    var currentLatitude = _coordinate.Latidude;
                    var currentLontitude = _coordinate.Longtitude;

                    var currentForeCastWeatherInformation = _repository.
                        GetAllWeatherForeCastInformation
                        (currentLatitude, currentLontitude, indicator);

                    _mainForeCastObject = currentForeCastWeatherInformation;

                    return _mainForeCastObject;
                }
                else
                    throw new Exception("Some parametrs are null");
            }
            else
                throw new Exception("No internet exeption");
            

        }
    }
}
