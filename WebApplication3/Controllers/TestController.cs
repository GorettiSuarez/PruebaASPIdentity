using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    [RoutePrefix("Test")]
    public class TestController : ApiController
    {

        [Route("HelloWorld")]
        [Authorize]
        [HttpGet]
        public HttpResponseMessage HelloWorld()
        {
            
            return Request.CreateResponse(HttpStatusCode.OK,"hello");
            
        }
    }
}