using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace SecurityPipelineOWIN.Pipeline
{
    [AuthenticationFilter]
    [AuthorizationFilter]
    public class TestController:ApiController
    {
        public IHttpActionResult Get()
        {
            Helper.Write("Controller", User);// Request.GetRequestContext().Principal);
            return Ok();
        }
    }
}