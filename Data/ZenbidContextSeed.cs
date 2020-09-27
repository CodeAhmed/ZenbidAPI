using MongoDB.Driver;
using Sales.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.API.Data
{
    public class ZenbidContextSeed
    {
        public static void SeedData(IMongoCollection<ZenbidSale> saleCollection)
        {
            bool existSale = saleCollection.Find(p => true).Any();
            if (!existSale)
            {
                saleCollection.InsertManyAsync(GetPreConfiguredSale());
            }
        
        }

        private static IEnumerable<ZenbidSale> GetPreConfiguredSale()
        {
            return new List<ZenbidSale>()
            {
                new ZenbidSale()
                {

                    sale_number = "21007",
                    sale_start_date = "2020-09-02T00:00:00",
                    sale_end_date = "2020-10-01T00:00:00",
                    sale_date_display_text = "Happening today",
                    image_src = "https://staging.christies.com/static/images/christies-roundel.svg",
                    title = "ACM-19823 DUB Physical sale",
                    description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    location = "Dubai",
                    bidamount = 100,
                    streaming = 1
                },

                new ZenbidSale()
                {

                    sale_number = "20323",
                    sale_start_date = "2020-09-02T00:00:00",
                    sale_end_date = "2020-10-01T00:00:00",
                    sale_date_display_text = "Happening today",
                    image_src = "https://staging.christies.com/static/images/christies-roundel.svg",
                    title = "*****ACM 19823 NYC Physical *****",
                    description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    location = "London",
                    bidamount = 150,
                    streaming = 0
                },

                new ZenbidSale()
                {

                    sale_number = "20323",
                    sale_start_date = "2020-09-02T00:00:00",
                    sale_end_date = "2020-10-01T00:00:00",
                    sale_date_display_text = "Happening today",
                    image_src = "https://staging.christies.com/static/images/christies-roundel.svg",
                    title = "*****ACM 19823 NYC Physical *****",
                    description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    location = "London",
                    bidamount = 300,
                    streaming = 0
                },

                new ZenbidSale()
                {

                    sale_number = "18874",
                    sale_start_date = "2020-09-21T00:00:00",
                    sale_end_date = "2020-09-21T00:00:00",
                    sale_date_display_text = "Happening today",
                    image_src = "https://staging.christies.com/static/images/christies-roundel.svg",
                    title = "Classic Art Evening Sale: Antiquity to 20th Century",
                    description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    location = "Paris",
                    bidamount = 200,
                    streaming = 0
                }
            };
        }
    }
}
