using System.Linq;
using System.Security.Claims;
using System.Web.Mvc;

namespace OktaWebDemo.Views
{
    public abstract class BaseWebViewPage : WebViewPage
    {
        protected bool IsAuthenticated => Context.User.Identity.IsAuthenticated;
        protected string IdentityName => Context.User.Identity.Name;
        protected string IdentityEmail => ((ClaimsIdentity) Context.User.Identity).Claims
                                          .SingleOrDefault(o => o.Type.Equals("email"))?.Value ?? string.Empty;
    }

    public abstract class BaseWebViewPage<TModel> : WebViewPage<TModel>
    {
        protected bool IsAuthenticated => Context.User.Identity.IsAuthenticated;
        protected string IdentityName => Context.User.Identity.Name;
        protected string IdentityEmail => ((ClaimsIdentity)Context.User.Identity).Claims
                                          .SingleOrDefault(o => o.Type.Equals("email"))?.Value ?? string.Empty;
    }
}