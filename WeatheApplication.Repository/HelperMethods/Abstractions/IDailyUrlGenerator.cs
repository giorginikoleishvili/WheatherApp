using System;
using System.Collections.Generic;
using System.Text;

namespace WeatheApplication.Repository.HelperMethods
{
    interface IDailyUrlGenerator : IUrlGenerator
    {
        string GetDailyUrlLinkC(string MainUrl, string DailyLink, string Lat, string Lon);


    }
}
