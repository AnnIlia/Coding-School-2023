using FuelStation.Model;
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FuelStation.Web.Shared.Item
{
    public class ItemEditDto
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }

        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        //Relations
        public List<TransactionLine> TransactionLines { get; set; } = new();
    }
}
