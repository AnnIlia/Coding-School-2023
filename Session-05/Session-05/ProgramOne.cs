﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    class ProgrammOne
    {
        static void ReverseString()
        {
            string name = "";
            string reverse = "";
            int Length = 0;
            Console.WriteLine("Enter your name: ");
            
            name = Console.ReadLine();
            //TODO: suggestion - check the given word. Accept ONLY letters.

            Length = name.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + name[Length];
                Length--;
            }
           
            Console.WriteLine($"Your revesed name is {reverse}");
            Console.ReadLine();

            public int ReverseString()
            {
                return 0;
            }


        }
    }
}







