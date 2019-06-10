using System;
using System.Collections.Generic;
using System.Text;

namespace WeatheApplication.Repository.HelperMethods.Implementation
{
    public class ForeCastUrlGenerator : IForeCastUrlGenerator
    {
        public string GetForeCastLinkC(string MainUrl, string ForeCastLink, string Lat, string Lon)
        {
            return MainUrl + ForeCastLink + $"lat={Lat}&" + $"lon={Lon}&units=metric" + "&appid=4b22875f640574a14f703820b61d488c";
        }

        public string GetForeCastLinkF(string MainUrl, string ForeCastLink, string Lat, string Lon)
        {
            return MainUrl + ForeCastLink + $"lat={Lat}&" + $"lon={Lon}&units=imperial" + "&appid=4b22875f640574a14f703820b61d488c";
        }
    }
}
