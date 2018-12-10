using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SampleDotNetFrameworkApp.Controllers
{
    public class TestController : ApiController
    {
        public string Get()
        {
            return "Hello, welcome to azure devops.. Dotnetframework...";
        }
    }
}