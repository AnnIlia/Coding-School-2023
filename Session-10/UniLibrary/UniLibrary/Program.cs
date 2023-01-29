// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello, World this is is is is!");

namespace UniLibrary
{
    internal class Programm
    {

        private static void Main(string[] args)
        {
            

            Student[] students = new Student[30];

            
            
            Course[] courses = new Course[20];   

            Schedule[] schedule = new Schedule[60];

            

            Professor professors = new Professor();

            //professors.SetName("Roupina");
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










