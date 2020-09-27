using Sales.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.API.Repositories.Interfaces
{
    public interface IZenbidSaleRepository
    {
        Task<IEnumerable<ZenbidSale>> GetSales();
        Task<ZenbidSale> GetSaleById(string id);
        Task<IEnumerable<ZenbidSale>> GetSaleByTitle(string title);


        Task Create(ZenbidSale sale);
        Task<bool> Update(ZenbidSale sale);
        Task<bool> Delete(string id);
    }
}
