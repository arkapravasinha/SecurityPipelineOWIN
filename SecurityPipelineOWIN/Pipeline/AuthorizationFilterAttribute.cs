using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace SecurityPipelineOWIN.Pipeline
{
    public class AuthorizationFilterAttribute:AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            Helper.Write("Authorize Attribute", actionContext.RequestContext.Principal);
            //return base.IsAuthorized(actionContext);

            return true;
        }
    }
}