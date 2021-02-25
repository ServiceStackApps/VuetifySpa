using System;
using ServiceStack;
using VuetifySpaTemplate.ServiceModel;

namespace VuetifySpaTemplate.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
