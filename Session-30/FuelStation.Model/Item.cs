namespace FuelStation.Model

public class Item
{
	public Item()
	{
		public int Id { get; set; }
		public string Code { get; set; }
	    public string Description { get; set; }
	    public ItemType ItemType { get; set; }
	    public decimal Price { get; set; }
	    public decimal Cost { get; set; }

	public Item()
	{
        Code = code;
        Description = description;
        ItemType = itemType;
        Price = price;
        Cost = cost;
        TransactionLines = new List<TransactionLine>();
    }

    //Relationships
    public List<TransactionLine> TransactionLines { get; set; }

}


}
