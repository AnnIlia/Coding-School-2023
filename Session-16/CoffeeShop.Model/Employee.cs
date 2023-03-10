using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{
    public enum EmployeeType
    {
        Manager,
        Cashier,
        Barista,
        Waiter
    }

    public class Employee : IEntityBase
    {
       //Properties
       public Guid ID { get; set; }
       public string Name { get; set; }
       public string Surname { get; set; }
       
       // public enum EmployeeType { get; set; }
       public EmployeeType TypeOfEmployee { get; set; }

       //public List<Employee>? employees;


        public decimal SalaryPerMonth { get; set; }
        public Transaction Transaction { get; set; }

        //Constructors
        public Employee()
        {
            ID = Guid.NewGuid();
        }
    }

    /* Each shop should have: 1 Manager, 1-2 Cashiers, 1-2 Baristas and 1-3 Waiters */

  

    
   

    //Methods
}

