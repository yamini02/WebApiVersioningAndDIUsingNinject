using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiVersioningWithNinject.Models;

namespace WebApiVersioningWithNinject.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/values")]
    public class ValuesController : ApiController
    {
        public IDetail Detail { get; set; }
        public ValuesController(IDetail detail)
        {
            this.Detail = detail;
        }
        public IHttpActionResult Get() => Ok("Value1");
    }

    [ApiVersion("2.0")]
    [Route("api/values")]
    public class Values2Controller : ApiController
    {
        public IHttpActionResult Get() => Ok("Value2");
    }

    [ApiVersion("3.0")]
    [Route("api/values")]
    public class Values3Controller : ApiController
    {
        public IHttpActionResult Get() => Ok("Value3");
    }

    [ApiVersion("3.1-alpha")]
    [Route("api/values")]
    public class Values4Controller : ApiController
    {
        public IHttpActionResult Get() => Ok("Value3-alpha");
    }
}
