using FuelStation.Enums;
using FuelStation.Model;
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FuelStation.Web.Shared.Employee
{

    // edit & list
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public int SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        //Relations
    }
}
