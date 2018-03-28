using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack;

namespace MVCServiceStack
{
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }

    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }

}
