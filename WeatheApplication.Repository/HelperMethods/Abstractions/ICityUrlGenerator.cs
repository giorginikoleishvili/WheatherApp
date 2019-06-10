using System;
using System.Collections.Generic;
using System.Text;

namespace WeatheApplication.Repository.HelperMethods.Abstractions
{
    public interface ICityUrlGenerator
    {
        string GenerateCityUrl(string cityName);
    }
}
