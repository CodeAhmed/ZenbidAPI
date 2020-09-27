
using Microsoft.AspNetCore.SignalR;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.API.Entities
{
    public class ZenbidSale
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
       // [BsonElement("title")]
        public string sale_number { get; set; }
        public string sale_start_date { get; set; }
        public string sale_end_date { get; set; }
        public string sale_date_display_text { get; set; }
        public string image_src { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public int bidamount { get; set; }
        public int streaming { get; set; }
    }
}
