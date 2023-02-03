using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop.model
{
    
    public class ProductCategory : IEntityBase
    {
        //properties
        public Guid id { get; set; }
        public int code { get; set; }
        public string description { get; set; }
        public object product { get; set; }
        public object producttype { get; set; }
        public object Code { get; set; }
        public object ProductType { get; set; }
        public object Description { get; set; }
        public object Product { get; set; }

        public ProductCategory() => id = Guid.NewGuid();
    }
}
