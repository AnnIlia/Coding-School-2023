using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CHANGE STARTUP: Session-05 > Properties: Application:  (select each app - .cs file)  

namespace Session_05
{
    internal class ProgramFive
    {
        
        public Array[] Sort()
        {

            int[] array1 = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            int temp;
            // traverse 0 to array length
            for (int i = 0; i < array1.Length - 1; i++)
            {

                // traverse i+1 to array length
                for (int j = i + 1; j < array1.Length; j++)
                {

                    // compare array element with
                    // all next element
                    if (array1[i] > array1[j])
                    {

                        temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);   
            }
        }

        public Array[] Sort()
        {
            return;
        }
    }
}
