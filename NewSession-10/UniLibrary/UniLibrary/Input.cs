using System;

namespace Session_06
{


    public class Input
    {


        public int GetNumber()
        {

            return Convert.ToInt32(GetString());

        }

        public string GetString()
        {

            string s = Console.ReadLine();

            return s;
        }

    }
}