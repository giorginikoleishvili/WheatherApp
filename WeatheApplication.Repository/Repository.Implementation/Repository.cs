using System.Collections.Generic;
using System.Threading.Tasks;
using WeatheApplication.Repository.HelperMethods.Implementation;
using WeatheApplication.Repository.Repository.Abstraction;
using WeatherApplication.Data.Models;
using WeatherApplication.Data.Models.Coordinats.Datas;
using WeatherApplication.Data.Models.DailyWeatherModels;
using WeatherApplication.Network.Layer;
using WeatherApplication.Network.Layer.Implementation;

namespace WeatheApplication.Repository.Repository.Implementation
{
    public class Repository : IRepository
    {
        private string _mainUrl = @"https://api.openweathermap.org/data/2.5/";
        private string _dailyLink = "weather?";
        private string _foreCastLink = "forecast?";

        private DailyWeather _wholeDailyWeather = new DailyWeather();
        private ForeCastWeather _wholeForeCastWeather = new ForeCastWeather();

        private HttpsRequest _gettingRequestAsync = new HttpsRequest();
        private DailyUrlGenerator _dailyUrlGenerator = new DailyUrlGenerator();
        private CityUrlGenerator _cityUrlGenerator = new CityUrlGenerator();
        private ForeCastUrlGenerator _foreCastUrlGenerator = new ForeCastUrlGenerator();
        private DeserializeObjcet<DailyWeather> _deserializingDailyWeather = new DeserializeObjcet<DailyWeather>();
        private DeserializeObjcet<ForeCastWeather> _deserializingForecastWeather = new DeserializeObjcet<ForeCastWeather>();
        private DeserializeObjcet<Welcome> _deserilizeWelcomeObject = new DeserializeObjcet<Welcome>();




        public DailyWeather GetAllDailyWeatherInformation(string lat, string lon, string choise = "C")
        {
            if (choise == "C")
            {
                var json =CurrentJsonForDailyWeatherC(_dailyLink, lat, lon);


                var deserilizedDailyWeather = _deserializingDailyWeather
                    .DeserializeJson(json.Result);

                _wholeDailyWeather = deserilizedDailyWeather;

                return _wholeDailyWeather;
            }
            else
            {
                var json = CurrentJsonForDailyWeatherF(_dailyLink, lat, lon);


                var deserilizedDailyWeather = _deserializingDailyWeather
                    .DeserializeJson(json.Result);

                _wholeDailyWeather = deserilizedDailyWeather;

                return _wholeDailyWeather;
            }
        }

        public ForeCastWeather GetAllWeatherForeCastInformation(string lat, string lon, string choise = "C")
        {
            if (choise == "C")
            {
                var json = CurrentJsonForForeCastWeatherC(_foreCastLink, lat, lon);

                var deserilizedForeCastWeather = _deserializingForecastWeather
                    .DeserializeJson(json.Result);

                var result = deserilizedForeCastWeather;

                _wholeForeCastWeather = result;

                return _wholeForeCastWeather;
            }
            else
            {
                var json = CurrentJsonForForeCastWeatherF(_foreCastLink, lat, lon);

                var deserilizedForeCastWeather = _deserializingForecastWeather
                    .DeserializeJson(json.Result);

                var result = deserilizedForeCastWeather;

                _wholeForeCastWeather = result;

                return _wholeForeCastWeather;
            }

        }

        public async Task<List<string>> GetCoordinatsByName(string cityName)
        {

            var url = _cityUrlGenerator.GenerateCityUrl(cityName);

            var generetedJson = await JsonUrlGenerator(url);

            var welcomeObject = _deserilizeWelcomeObject.DeserializeJson(generetedJson);
            var results = welcomeObject.Results;

            var lat = results[0].Geometry.Lat.ToString();
            var lon = results[0].Geometry.Lng.ToString();

            return new List<string>
            {
                lat,lon
            };

        }



        private async Task<string> JsonUrlGenerator(string url)
        {
            var generetedUrlTask = await _gettingRequestAsync.GetRequest(url);

            return generetedUrlTask;
        }



        //Celsius
        private string DailyUrlGeneratorC(string dailyLink, string lat, string lon)
        {
            return _dailyUrlGenerator.GetDailyUrlLinkC(_mainUrl, dailyLink, lat, lon);
        }

        private string ForeCastUrlGeneratorC(string ForeCastLink, string lat, string lon)
        {
            return _dailyUrlGenerator.GetDailyUrlLinkC(_mainUrl, ForeCastLink, lat, lon);
        }
        ///

        //farengeit
        private string DailyUrlGeneratorF(string dailyLink, string lat, string lon)
        {
            return _dailyUrlGenerator.GetDailyUrlLinkF(_mainUrl, dailyLink, lat, lon);
        }

        private string ForeCastUrlGeneratorF(string ForeCastLink, string lat, string lon)
        {
            return _dailyUrlGenerator.GetDailyUrlLinkF(_mainUrl, ForeCastLink, lat, lon);
        }
        ///////
        ///





        ///FAR
        private async Task<string> CurrentJsonForDailyWeatherC(string dailyWeatherLink, string lat, string lon)
        {
            return await JsonUrlGenerator(DailyUrlGeneratorC(dailyWeatherLink, lat, lon));
        }

        private async Task<string> CurrentJsonForForeCastWeatherC(string dailyWeatherLink, string lat, string lon)
        {
            return await JsonUrlGenerator(ForeCastUrlGeneratorC(dailyWeatherLink, lat, lon));
        }

        //CELL
        private async Task<string> CurrentJsonForDailyWeatherF(string dailyWeatherLink, string lat, string lon)
        {
            return await JsonUrlGenerator(DailyUrlGeneratorF(dailyWeatherLink, lat, lon));
        }

        private async Task<string> CurrentJsonForForeCastWeatherF(string dailyWeatherLink, string lat, string lon)
        {
            return await JsonUrlGenerator(ForeCastUrlGeneratorF(dailyWeatherLink, lat, lon));
        }




        ////
        ///



    }
}
