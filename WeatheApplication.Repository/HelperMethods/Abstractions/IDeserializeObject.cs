using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Network.Layer.Abstraction
{
    public interface IDeserializeObject<Tobject>
    {
        Tobject DeserializeJson(string Json);
    }
}
