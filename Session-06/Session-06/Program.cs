// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello, World this is is is is!");

namespace Session_06
{
    internal class Programm
    {

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World this is is is is!");

            Student[] students = new Student[30];

            //Professor[] professors = new Professor[5];
            
            Course[] courses = new Course[20];   

            Schedule[] schedule = new Schedule[60];

            //professors[0].Name="takis";

            Professor professors = new Professor();

            professors.SetName("Roupina");
            Console.WriteLine(professors.GetName());
        }

    /*
        public int GetName()
        {

            return Convert.ToInt32(GetString());
        }


        public int SetName()
        {

            return Convert.ToInt32(GetString());
        }
    */

    }
}










