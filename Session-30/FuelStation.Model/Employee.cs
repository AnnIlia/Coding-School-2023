using FuelStation.Enums;

namespace FuelStation.Model
{

    public class Employee
    {
        public Employee(string name, string surname, int sallaryPerMonth, EmployeeType employeeType)
        {
            Name = name;
            Surname = surname;
            SallaryPerMonth = sallaryPerMonth;
            EmployeeType = employeeType;

            Transactions = new List<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public int SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
