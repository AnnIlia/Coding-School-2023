namespace FuelStation.Model

public class Transaction
{
    public Transaction(decimal totalPrice, PaymentMethod paymentMethod)
    {
        Date = DateTime.Now;
        TotalValue = totalValue;
        PaymentMethod = paymentMethod;

        TransactionLines = new List<TransactionLine>();
    }

    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal TotalValue { get; set; }
    public PaymentMethod PaymentMethod { get; set; }

    // Relations
    public int EmployeeId { get; set; }
    public int Customer { get; set; }
    public Employee Employee { get; set; } = null!;
    public Customer Customer { get; set; } = null!;

    public List<TransactionLine> TransactionLines { get; set; }
}
