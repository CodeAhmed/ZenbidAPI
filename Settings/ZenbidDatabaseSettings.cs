using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.API.Settings
{
    public class ZenbidDatabaseSettings : IZenbidDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public  string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}
