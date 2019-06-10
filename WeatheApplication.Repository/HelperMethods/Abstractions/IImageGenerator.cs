using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace WeatheApplication.Repository.HelperMethods.Abstractions
{
    public interface IImageGenerator
    {
        string ImageUrlGenerator(string iconId);
    }
}
