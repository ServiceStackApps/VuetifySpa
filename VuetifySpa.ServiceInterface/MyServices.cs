using System;
using ServiceStack;
using VuetifySpa.ServiceModel;

namespace VuetifySpa.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
