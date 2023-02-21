using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FuelStation.Web.Shared.Customer
{
    public class CustomerEditDto
    {
        public int Id { get; set; }
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Name field can only contain Latin letters ")]
        [Required]
        public string Name { get; set; }
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Surname field can only contain Latin letters ")]
        [Required]
        public string Surname { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", Name, Surname);
            }
        }
        [RegularExpression(@"^A\d+$", ErrorMessage = "Card number must start with 'A' and contain only digits")]
        [Required]
        public string CardNumber { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
