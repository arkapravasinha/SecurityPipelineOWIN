using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityPipelineOWIN.Pipeline
{
    public class HTTPModule : IHttpModule
    {
        public void Dispose()
        {
           // throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += Context_BeginRequest;
        }

        private void Context_BeginRequest(object sender, EventArgs e)
        {
            Helper.Write("HTTP Module", HttpContext.Current.User);
        }
    }
}