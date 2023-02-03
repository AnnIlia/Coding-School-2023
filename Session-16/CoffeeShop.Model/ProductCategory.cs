using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop.model
{
    
    public class Productcategory
    {
        //properties
        public Guid id { get; set; }
        public int code { get; set; }
        public string description { get; set; }
        public object product { get; set; }
        public object producttype { get; set; }

        public Productcategory() => id = Guid.NewGuid();
    }
}
