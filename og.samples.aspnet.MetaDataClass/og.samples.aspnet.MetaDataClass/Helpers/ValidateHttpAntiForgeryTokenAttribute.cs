using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Filters;

namespace og.samples.aspnet.Demo.helper
{
    /// <summary>
    /// simple token validation attribute for web api
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class ValidateHttpAntiForgeryTokenAttribute : ActionFilterAttribute
    {
        private const string HeaderTokenName = "X-XSRF-Token";
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (actionContext == null)
            {
                throw new ArgumentNullException("actionContext");
            }

            var headers = actionContext.Request.Headers;           
            IEnumerable<string> tokens;

            try
            {
                if (headers.TryGetValues(HeaderTokenName, out tokens))
                {
                    var headerToken = tokens.FirstOrDefault();
                    var cookie = headers.GetCookies().Select(c => c[AntiForgeryConfig.CookieName]).FirstOrDefault();
                    var cookieToken = cookie != null ? cookie.Value : null;
                    AntiForgery.Validate(cookieToken, headerToken);
                }
                else
                {

                    string msg = HttpStatusCode.ExpectationFailed.ToString()+ " - " + HeaderTokenName;
                    throw new InvalidOperationException(msg);
                }    
            } catch{
                actionContext.Response = new HttpResponseMessage
                {
                    RequestMessage = actionContext.ControllerContext.Request,
                    StatusCode = HttpStatusCode.Forbidden,
                    ReasonPhrase = "Invalid Token"
                };                             
            }
                                           
            base.OnActionExecuting(actionContext);
        }
       
    }


}