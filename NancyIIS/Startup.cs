using Microsoft.Owin;
using NancyIIS;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace NancyIIS
{
    public class Startup
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.UseNancy();
        }
    }
}