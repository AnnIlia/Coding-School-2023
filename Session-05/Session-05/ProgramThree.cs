using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ProgramThree
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int i = 0;
            int num = 0;

            for (num = 1; num <= n; num++)
            {
                count = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                    else {
                        //Console.Write("else\n");
                    }
                    
                }
                
                if (count == 0 && num != 1)
                {
                    Console.Write(num + " \n" );
                }

            }

        }

        }
    }

