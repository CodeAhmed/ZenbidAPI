using MongoDB.Driver;
using Sales.API.Entities;
using Sales.API.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.API.Data
{
    public class ZenbidContext : IZenbidContext
    {
        public ZenbidContext(IZenbidDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            Sales = database.GetCollection<ZenbidSale>(settings.CollectionName);
            ZenbidContextSeed.SeedData(Sales);
        }
        
        public IMongoCollection<ZenbidSale> Sales { get; }


    }
}
