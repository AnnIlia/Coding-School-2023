namespace FuelStation.Model
{
    public class Customer
    {
        public Customer(string name, string surname, string CardNumber)
        {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
            Transactions = new List<Transaction>();
        }

        public Customer()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private string _cardNumber;
        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                if (value.StartsWith("A"))
                {
                    _cardNumber = value;
                }
                else
                {
                    throw new ArgumentException("Card number must start with 'A'");
                }
            }
        }

        // Relations
        public List<Transaction> Transactions { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", Name, Surname);
            }
        }
    }
}


