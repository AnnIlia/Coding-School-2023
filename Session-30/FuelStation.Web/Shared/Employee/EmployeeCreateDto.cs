using FuelStation.Enums;
using FuelStation.Model;
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FuelStation.Web.Shared.Employee
{

    // edit & list
    public class EmployeeCreateDto
    {
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Name field can only contain Latin letters ")]
        [Required]
        public string Name { get; set; }
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Surname field can only contain Latin letters ")]
        [Required]
        public string Surname { get; set; }
        [Required]
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        [Required]
        public int SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        //Relations
    }
}
