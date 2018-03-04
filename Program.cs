using System;
using movingToTheWeb;
using Microsoft.AspNetCore.Hosting;

namespace supermva
{
    class Program
    {
        static void Main(string[] args)
        {
          var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .Build();

          host.Run();
          }
    }
}
