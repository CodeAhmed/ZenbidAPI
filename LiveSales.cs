using System;

namespace Sales.API
{
    public class LiveSales
    {
        public string SaleNumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string SaleDisplayText { get; set; }
        public string ImageSrc { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string BidAmount { get; set; }
        public int  Streaming { get; set; }

    }
}
