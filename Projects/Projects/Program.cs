using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Projects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().SetBasePath($@"{Directory.GetCurrentDirectory()}\Configuration").AddJsonFile("Config.json").Build();

            BuildWebHost(args, builder).Run();
        }

        public static IWebHost BuildWebHost(string[] args, IConfiguration configuration) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>().UseConfiguration(configuration)
                .Build();
    }
}
