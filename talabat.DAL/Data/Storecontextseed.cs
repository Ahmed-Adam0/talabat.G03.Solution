using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using talabat.DAL.Entities;

namespace talabat.DAL.Data
{
    public  class Storecontextseed
    {
        public  static async Task SeedAsync(Storecontext context,ILoggerFactory loggerFactory)
        {
            try 
            {
                if (!context.productBrand.Any())
                { 
                    var brandData = File.ReadAllText("../talabat.DAL/Data/seedData/brands.json");
                    var brands = JsonSerializer.Deserialize<List<productBrand>>(brandData);
                    foreach (var brand in brands)
                    {
                        context.Set<productBrand>().Add(brand);
                    }
                    await context.SaveChangesAsync();
                }
            }
            catch(Exception EX) 
            {
                var logger = loggerFactory.CreateLogger<Storecontextseed>();
                logger.LogError(EX, EX.Message);
            }
           
        }
    }
}
