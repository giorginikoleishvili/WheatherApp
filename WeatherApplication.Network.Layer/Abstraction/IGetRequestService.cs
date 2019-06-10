using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApplication.Network.Layer
{
    public interface IGetRequestService
    {
        string GetRequest(string uri);
    }
}
