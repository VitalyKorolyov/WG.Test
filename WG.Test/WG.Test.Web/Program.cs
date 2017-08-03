using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace WG.Test.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .UseUrls("http://localhost:8080/")
                .Build();

            host.Run();
        }
    }
}
