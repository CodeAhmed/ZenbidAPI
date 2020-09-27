using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sales.API.Entities;

namespace Sales.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LiveSalesController : ControllerBase
    {
        private static readonly string[] SaleNumber = new[]
        {
            "21007", "20323", "18874", "20521"
        };

        private static readonly string[] StartDate = new[]
        {
            "2020-09-02T00:00:00", "2020-09-02T00:00:00", "2020-09-21T00:00:00", "2020-09-21T00:00:00"
        };

        private static readonly string[] EndDate = new[]
        {
            "2020-10-01T00:00:00", "2020-10-01T00:00:00", "2020-09-21T00:00:00", "2020-09-21T00:00:00"
        };

        private static readonly string[] ImageSrc = new[]
        {
         "https://staging.christies.com/static/images/christies-roundel.svg","https://staging.christies.com/static/images/christies-roundel.svg", "https://staging.christies.com/img/saleimages/cks-18874-07292020-1.jpg","https://staging.christies.com/static/images/christies-roundel.svg"
        };

        private static readonly string[] BidAmount = new[]
        {
            "100", "150", "200", "500"
        };

        private static readonly string[] Location = new[]
        {
            "Dubai", "London", "New York", "Paris"
        };

        private static readonly string[] Title = new[]
        {
            "ACM-19823 DUB Physical sale", "*****ACM 19823 NYC Physical *****", "Classic Art Evening Sale: Antiquity to 20th Century", "Sacred and Imperial: The James and Marilynn Collection"
        };

        private static readonly string[] Description = new[]
        {
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.","Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
        };

        private static readonly int[] Streaming = new[]
       {
            1, 0, 0, 0
        };

        private readonly ILogger<LiveSalesController> _logger;

        public LiveSalesController(ILogger<LiveSalesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<LiveSales> Get()
        {
            var rng = new Random(); 
            return Enumerable.Range(1, 10).Select(index => new LiveSales
            {
                  SaleNumber = SaleNumber[rng.Next(SaleNumber.Length)],
                  Title = Title[rng.Next(Title.Length)],
                Description = Description[rng.Next(Description.Length)],
                StartDate = StartDate[rng.Next(StartDate.Length)],
                  EndDate = EndDate[rng.Next(EndDate.Length)],
                  ImageSrc = ImageSrc[rng.Next(ImageSrc.Length)],
                Location = Location[rng.Next(Location.Length)],
                BidAmount = BidAmount[rng.Next(BidAmount.Length)],
                Streaming = Streaming[rng.Next(Streaming.Length)]
            })
            .ToArray();
        }
    }
}
