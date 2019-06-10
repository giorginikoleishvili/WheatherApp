using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using WeatheApplication.Repository.HelperMethods.Abstractions;

namespace WeatheApplication.Repository.HelperMethods.Implementation
{
    public class ImageGenerator : IImageGenerator
    {
        public string ImageUrlGenerator(string iconId)
        {
            return "http://openweathermap.org/img/w/" + $"{iconId}" +".png?fbclid=IwAR1GNfEyHl8Yw-qbsqataqYEmt1GjUjwfg-swZ6zwftT31_ZfxRd5OY3Vf4";
        }
    }
}
