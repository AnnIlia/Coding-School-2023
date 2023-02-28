using FuelStation.Enums;
using FuelStation.Model;
using FuelStation.Web.Shared.Customer;
using FuelStation.Web.Shared.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.Transaction
{
    public class TransactionCreateDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        public CustomerListDto Customer { get; set; } = null;
        public EmployeeDto Employee { get; set; } = null;
        public List<TransactionLine> TransactionLines { get; set; }
    }
}
