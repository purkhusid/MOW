using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace MOW.DotNetCoreApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseKestrel()
                .Build();

            host.Run();
        }
    }
}