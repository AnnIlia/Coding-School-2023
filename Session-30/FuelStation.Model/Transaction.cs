using FuelStation.Enums;

namespace FuelStation.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        public Transaction(DateTime date, PaymentMethod paymentMethod, decimal totalValue) { }

        public List<TransactionLine> TransactionLines { get; set; }

    }
}



