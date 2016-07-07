using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;

namespace WebDeveloper
{
   public partial  class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType =DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath=new PathString("/Account/Login") 
            });
        }
    }
}
