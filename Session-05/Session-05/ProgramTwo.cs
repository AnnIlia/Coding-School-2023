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
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            //int product = 0;
            
            Console.Write("Select Operation: Press 1 for Summarize or 2 for Product ");
            int operation = Convert.ToInt32(Console.ReadLine());
            if (operation == 1) {Console.WriteLine("SUM") }
            { if (operation == 2) { Console.WriteLine("PRODUCT")} { Console.WriteLine("Oops..Select between 1 or 2, please") } };


            Console.WriteLine("Sum of the digits of the said integer: " + sum);

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
        }
    }

}
    