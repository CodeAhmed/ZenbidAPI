using MongoDB.Driver;
using Sales.API.Data;
using Sales.API.Entities;
using Sales.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.API.Repositories
{
    public class ZenbidSaleRepository : IZenbidSaleRepository
    {

        private readonly IZenbidContext _context;

        public ZenbidSaleRepository(IZenbidContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<ZenbidSale>> GetSales()
        {
            return await _context
                            .Sales
                            .Find(p => true)
                            .ToListAsync();                            
        }

        public async Task<ZenbidSale> GetSaleById(string id)
        {
            return await _context
                            .Sales
                            .Find(p => p.Id == id)
                            .FirstOrDefaultAsync();
                            
        }

        public async Task<IEnumerable<ZenbidSale>> GetSaleByTitle(string title)
        {
            FilterDefinition<ZenbidSale> filter = Builders<ZenbidSale>.Filter.ElemMatch(p => p.title, title);
            return await _context
                            .Sales
                            .Find(filter)
                            .ToListAsync();
        }

        public async Task Create(ZenbidSale sale)
        {
            await _context.Sales.InsertOneAsync(sale);
        }

        public async Task<bool> Update(ZenbidSale sale)
        {
            var updateResult = await _context
                                        .Sales
                                        .ReplaceOneAsync(filter: g => g.Id == sale.Id, replacement: sale);

            return updateResult.IsAcknowledged
                && updateResult.ModifiedCount > 0;
        }

        public async Task<bool> Delete(string id)
        {
            FilterDefinition<ZenbidSale> filter = Builders<ZenbidSale>.Filter.Eq(p => p.Id, id);

            DeleteResult deleteResult = await _context
                            .Sales
                            .DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;

        }           
    }
}
