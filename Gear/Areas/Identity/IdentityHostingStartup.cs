using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Gear.Areas.Identity.IdentityHostingStartup))]
namespace Gear.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}