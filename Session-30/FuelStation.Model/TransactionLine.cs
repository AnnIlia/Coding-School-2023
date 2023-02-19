namespace FuelStation.Model
{
    public class TransactionLine
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        //Relations
        public int TransactionID { get; set; }
        public Transaction Transaction { get; set; } = null!;

        public int ItemID { get; set; }
        public Item Item { get; set; } = null!;
        public TransactionLine() { }

    }
}


