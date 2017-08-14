using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HelloWorldAPI.Controllers
{
    using System.Web.Http;
    public class HelloWorldController : ApiController
    {
        public interface IHelloWorldService
        {
            HelloWorldData GetHelloWorldData();
        }

        private IHelloWorldService helloWorldService;
        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            this.helloWorldService = helloWorldService;
        }
        [AcceptVerbs("GET")]
        public HelloWorldData GetData()
        {
            return this.helloWorldService.GetHelloWorldData();
        }

    }
}
