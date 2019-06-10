using System;
using System.Collections.Generic;
using System.Text;
using WeatheApplication.Repository.HelperMethods.Abstractions;

namespace WeatheApplication.Repository.HelperMethods.Implementation
{
    class CityUrlGenerator : ICityUrlGenerator
    {
        
        public string GenerateCityUrl(string cityName)
        {
            return @"https://api.opencagedata.com/geocode/v1/json?q=" + $"{cityName}" + "&key=a7457c4dcf4346d8b0a77d8288354c6e#";
        }
    }
}
