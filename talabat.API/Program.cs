using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using talabat.DAL.Data;

namespace talabat.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
           using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            var LoggerFactory =services.GetRequiredService<ILoggerFactory>();
            try 
            {
                var context=services.GetRequiredService<Storecontext>();
                await context.Database.MigrateAsync();
                await Storecontextseed.SeedAsync(context, LoggerFactory);
            }
            catch(Exception ex)
            {
                var logger = LoggerFactory.CreateLogger<Program>();
                logger.LogError(ex,"an error in this migration");
            }
            host.Run(); 
           
            //Storecontext context=new Storecontext();
            //await context.Database.MigrateAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
