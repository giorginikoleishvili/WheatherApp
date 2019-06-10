using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApplication.Network.Layer.Abstraction
{
    public interface IDeserializeObject<Tobject>
    {
        Tobject DeserializeJson(string Json);
    }
}
