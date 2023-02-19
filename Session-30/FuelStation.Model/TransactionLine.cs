namespace FuelStation.Model

public class TransactionLine
{
    public TransactionLine(int quantity, decimal discount, decimal itemPrice, decimal netValue, decimal totalValue)
    {
        Quantity = quantity;
        Discount = discount;
        ItemPrice = itemPrice;
        NetValue = netValue;
        TotalValue = totalValue;
    }

    public int Id { get; set; }
    public int Quantity { get; set; }
    public decimal ItemPrice { get; set; }
    public decimal NetValue { get; set; }
    public decimal DiscountPercent { get; set; }
    public decimal DiscountValue { get; set; }
    public decimal TotalValue { get; set; }

    // Relations
    public int TransactionId { get; set; }
    public Transaction Transaction { get; set; } = null!;

    public int ItemId { get; set; }
    public  Item Item { get; set; } = null!;
}
