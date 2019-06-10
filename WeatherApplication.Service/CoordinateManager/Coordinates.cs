using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Service.ExtentionMethod;

namespace WeatherApplication.Service.CoordinateManager
{
    public struct Coordinates
    {

        public string Latidude { get; set; }
        public string Longtitude { get; set; }

        public void FindCooordinates(string lat = "", string lon = "") 
        {
            var watcher = new GeoCoordinateWatcher();
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));
            var coord = watcher.Position.Location;

            if (string.IsNullOrEmpty(lat) && string.IsNullOrEmpty(lon)) 
            {
                while(coord.IsUnknown)
                    coord = watcher.Position.Location;

                Latidude = coord.Latitude.ToString();
                Longtitude = coord.Longitude.ToString();
            }
            else
            {
                this.Latidude = lat;
                this.Longtitude = lon;
            }
        }

    }
}
