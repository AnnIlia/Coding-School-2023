using FuelStation.Model;
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FuelStation.Web.Shared.Item
{
    //mono gia tin create
    public class ItemCreateDto
    {
        
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "The Code field can contain Latin letters and digits ")]
        [Required]
        public string Code { get; set; }
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Description field can only contain Latin letters ")]
        [Required]
        public string Description { get; set; }
        public ItemType ItemType { get; set; } 
        //[RegularExpression(@"^[1-9][0-9]* (\.[0-9]+)?$", ErrorMessage = "The Price field can only digits")]
        //[Required]
        public decimal Price { get; set; }
        //[RegularExpression(@"^[1-9][0-9]* (\.[0-9]+)?$", ErrorMessage = "The Cost field can only digits")]
        //[Required]
        public decimal Cost { get; set; }

        //Relations

    }
}
