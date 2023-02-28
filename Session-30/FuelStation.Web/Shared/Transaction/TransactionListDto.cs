using FuelStation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.Transaction
{
    public class TransactionListDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalValue { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        //and with List<TransactionLineListDto>

    }
}
