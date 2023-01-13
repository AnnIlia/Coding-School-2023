using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class ProgramOne
    {
        static void Main(string[] args)
        {
            string str = "";
            string reverse = "";
            int Length = 0;
            Console.WriteLine("Enter your name");
            
            str = Console.ReadLine();
            //TODO: check the given word. Accept ONLY letters.
            
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
           
            Console.WriteLine("Your revesed name is {0}", reverse);
            Console.ReadLine();
        }
    }
}







