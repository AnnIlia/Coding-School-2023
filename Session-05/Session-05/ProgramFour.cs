﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ProgramFour
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[] { 2, 4, 9, 12 };
            int[] array2 = new int[] { 1, 3, 7, 10 };
            int[,] array3 = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array3[i,j] = array1[i] * array2[j];
                    Console.WriteLine(array3[i,j]); 
                }
            }
        }
    }
}
