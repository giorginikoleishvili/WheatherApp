using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Net;
using WeatherApplication.Network.Layer;
using WeatherApplication.Service.Abstraction;
using WeatherApplication.Service.Implementation;

namespace WeatherApplication.Service.ExtentionMethod
{
    public static class Extention
    {
        public static bool CheckInternetConnection(this IService service)
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        

        public static bool CheckToNull(this IService service, string tempIndicator, string lat, string lon)
        {
            return tempIndicator == null || lat == null || lon == null;
        }
        public static bool CheckToNull(this IService service, string cityName, string tempIndicator)
        {
            return cityName == null || tempIndicator == null;
        }
        public static bool CheckPhotoId(this GetImageUrlService getImageUrlService, string photoId)
        {
            return string.IsNullOrEmpty(photoId);
        }

        
    }


}
