using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AProjekt_Supermarked.Services;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AProjekt_Supermarked
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UDEN seeding af data    
            //BuildWebHost(args).Run();

            //MED seeding af data - bruges til in-memory database
            var host = BuildWebHost(args);

            using(var tmpscope = host.Services.CreateScope()){
                var services = tmpscope.ServiceProvider;
                var context=services.GetRequiredService<ShoppingContext>();
                SeedData.InitDb(services);
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
