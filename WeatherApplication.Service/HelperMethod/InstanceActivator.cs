using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Service.HelperMethod
{
    public class InstanceActivator
    {
        public Expression<Func<T>> InjectAndGetObject<T>(Type typeOfObject)
        {
            var creationExpression =
                Expression.New(typeOfObject.GetConstructor(Type.EmptyTypes));

            var mainExpression = Expression.Lambda<Func<T>>(creationExpression);

            return mainExpression;
        }
    }
}
