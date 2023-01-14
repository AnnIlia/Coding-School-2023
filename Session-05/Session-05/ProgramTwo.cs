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
            Console.Write("Input a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
        }
    }

}
    