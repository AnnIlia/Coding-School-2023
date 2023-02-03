using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CoffeeShop.Model
{
    public class Customer : IEntityBase
    { 
        public Guid ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        
        
        //Constructors
        public Customer() {
            ID = Guid.NewGuid();
            Code= 001;
            Description ="Retail Customer";
        }


        //Methods
        

        


    }

   

    
     

}



