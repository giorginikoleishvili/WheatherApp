using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatheApplication.Repository.HelperMethods.Implementation;
using WeatheApplication.Repository.Repository.Implementation;
using WeatherApplication.Service.ExtentionMethod;

namespace WeatherApplication.Service.Implementation
{
    public class GetImageUrlService
    {
        private ImageGenerator _imageGenerator = new ImageGenerator();
        public string GeneratingUrlForImage(string photoId)
        {
            var is_PhotoUrlNull = this.CheckPhotoId(photoId);
            if (!is_PhotoUrlNull)
                return _imageGenerator.ImageUrlGenerator(photoId);
            else
                throw new Exception("Photo Id is null or empty");
        }
    }
}
