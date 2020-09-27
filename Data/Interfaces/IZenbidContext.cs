using MongoDB.Driver;
using Sales.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.API.Data
{
    public interface IZenbidContext
    {
        IMongoCollection<ZenbidSale> Sales { get; }
    }
}
