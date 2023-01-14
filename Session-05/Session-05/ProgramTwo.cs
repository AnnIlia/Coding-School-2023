using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CHANGE STARTUP: Session-05 > Properties: Application:  (select each app - .cs file)  
namespace Session_05
{
    class ProgrammTwo
    { 
        public static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            
            
           
            Console.Write("Select Operation: s\nPress 1 for Summarize or 2 for Product");
            int operation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a number to perform the operation you selected");
            int numberB = Convert.ToInt32(Console.ReadLine());
            
            int sum = numberA + numberB;
            int product = numberA 

            resultSum = "$Summary of two numbers is: {0}", sum;

            if (operation == 1) {sum} else if (operation == 2) {product }
           // else if (operation == 2) { Console.WriteLine("PRODUCT")} 
           // else { Console.WriteLine("Oops..Select between 1 or 2, please") } ;

            
            Console.WriteLine("Sum of the digits of the said integer: " + sum);

            while (numberA != 0)
            {
                sum += numberA % 10;
                numberA /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
        }
    }

}
    