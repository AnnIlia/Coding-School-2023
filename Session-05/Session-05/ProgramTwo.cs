using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//I may not have understood the point correctly about the operation of Product

//CHANGE STARTUP: Session-05 > Properties: Application: (select each app - .cs file)  
namespace Session_05
{
    class ProgrammTwo
    { 
        public static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
                     
            Console.Write("Select Operation: Press 1 for Summarize or 2 for Product\n");
            int operation = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            int counter = 0;


            /* select the operation */
            if (operation == 1) {
                //do the sum
                counter = 0;
                while (counter < numberA) {
                    result = result + counter;
                    counter++;
                    Console.Write("result: " + result + "\n");
                }
                Console.Write("Selected Operation: Sum\n");
            }
            else if (operation == 2) {
                //do the product
                counter = 1;
                result = 1;
                while (counter < numberA+1)
                {
                    result = result * counter;
                    counter++;
                    Console.Write("result: " + result + "\n");
                }
                Console.Write("Selected Operation: product\n");
            }
            else {
                //wrong input print error message
                Console.Write("Wrong input, programm exit");
            }

            //print the result
            Console.Write("result: " + result);

        }
    }

}
    