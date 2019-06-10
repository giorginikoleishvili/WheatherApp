using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Network.Layer
{
    public interface IGetRequestService
    {
        Task<string> GetRequest(string uri);
    }
}
