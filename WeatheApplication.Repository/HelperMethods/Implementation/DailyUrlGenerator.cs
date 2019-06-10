using System;
using System.Collections.Generic;
using System.Text;

namespace WeatheApplication.Repository.HelperMethods.Implementation
{
    public class DailyUrlGenerator : IDailyUrlGenerator
    {

        public string GetDailyUrlLinkC(string MainUrl, string DailyLink,string Lat, string Lon)
        {
            return MainUrl + DailyLink + $"lat={Lat}&" + $"lon={Lon}&units=metric" + "&appid=4b22875f640574a14f703820b61d488c";
        }

        public string GetDailyUrlLinkF(string MainUrl, string DailyLink, string Lat, string Lon)
        {
            return MainUrl + DailyLink + $"lat={Lat}&" + $"lon={Lon}&units=imperial" + "&appid=4b22875f640574a14f703820b61d488c";
        }

    }
}
