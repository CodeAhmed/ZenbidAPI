using DnsClient.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sales.API.Entities;
using Sales.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Sales.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ZenbidSalesController : ControllerBase
    {
        private readonly IZenbidSaleRepository _repository;
        private readonly ILogger<ZenbidSalesController> _logger;

        public ZenbidSalesController(IZenbidSaleRepository repository, ILogger<ZenbidSalesController> logger)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ZenbidSale>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ZenbidSale>>> GetSales()
        {

            var sales = await _repository.GetSales();
            return Ok(sales);
        }

        [HttpGet("{id:length(24)})", Name = "GetSale")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ZenbidSale), (int)HttpStatusCode.OK)]        
        public async Task<ActionResult<ZenbidSale>> GetSaleById(string id)
        {

            var sale = await _repository.GetSaleById(id);

            if(sale == null)
            {
                _logger.LogError($"Sale with ID: {id} not found'");
                return NotFound();
            }
            
            return Ok(sale);
        }

        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable<ZenbidSale>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ZenbidSale>>> CreateZenbidSale([FromBody] ZenbidSale sale)
        {

            await _repository.Create(sale);

            return CreatedAtRoute("GetSales", new { id = sale }, sale);

        }

        [HttpPut]
        [ProducesResponseType(typeof(IEnumerable<ZenbidSale>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateZenbidSale([FromBody] ZenbidSale sale)
        {

            return Ok(await _repository.Update(sale));

        }

        [HttpDelete("{id:length(24)})")]
        [ProducesResponseType(typeof(IEnumerable<ZenbidSale>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteSaleById(string id)
        {

            return Ok(await _repository.Delete(id));
        }


    }
}
