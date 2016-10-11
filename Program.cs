using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;


namespace Random_Word
{
    public class Program
    {

        public static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }
    }
}