using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{
    public abstract class IEntityBase
    {
        public Guid ID { get; set; }
    }
}