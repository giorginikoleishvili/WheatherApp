using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Network.Layer.Abstraction;

namespace WeatherApplication.Network.Layer.Implementation
{
    public class DeserializeObjcet<Tobject> : IDeserializeObject<Tobject>
    {
        public Tobject DeserializeJson(string Json)
        {
            return JsonConvert.DeserializeObject<Tobject>(Json);
        }
    }
}
