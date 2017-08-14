using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FreeCandy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UserKestrel()
                .UseContectroot(Directory.GetCurrentDirectory())
                .UseStartup()
                .UsellSIntegration()
                .build();
            host.Rin();

        }
    }
}
