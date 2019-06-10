using System;
using System.Collections.Generic;
using System.Text;

namespace WeatheApplication.Repository.HelperMethods
{
    public interface IForeCastUrlGenerator : IUrlGenerator
    {
        string GetForeCastLinkC(string MainUrl,string ForeCastLink, string Lat, string Lon);
    }
}
