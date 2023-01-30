using System;
using static CoffeeShop.Model.Product;

namespace CoffeeShop.Model
{
    public enum EmployeeType
    {
        Manager,
        Cashier,
        Barista,
        Waiter
    }

    public class Employee
    {
       //Properties
       public Guid ID { get; set; }
       public string Name { get; set; }
       public string Surname { get; set; }
       
       // public enum EmployeeType { get; set; }
       public EmployeeType TypeOfEmployee { get; set; }

       //public List<Employee>? employees;


        public decimal SalaryPerMonth { get; set; }

        //Constructors
        public Employee()
        {
            ID = Guid.NewGuid();
        }
    }  
}

