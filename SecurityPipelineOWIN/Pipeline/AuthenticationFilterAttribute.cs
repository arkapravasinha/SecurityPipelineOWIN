using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace SecurityPipelineOWIN.Pipeline
{
    public class AuthenticationFilterAttribute : Attribute, IAuthenticationFilter
    {
        public bool AllowMultiple => false;

        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            Helper.Write("Authentication Filter",context.ActionContext.RequestContext.Principal);
            //throw new NotImplementedException();
        }

        public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
           // throw new NotImplementedException();
        }
    }
}