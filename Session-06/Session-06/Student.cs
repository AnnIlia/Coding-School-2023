using System;

namespace Session_06
{

    public class Student : Session_06.Person  
    {
        // properties
        public int RegistrationNumber { get; set; }
        public Course[]? courses { get; set; }



        // methods
        public void Attend(string Course, DateTime dateTime)
        {

        }

        public void WriteExam(string Course, DateTime dateTime)
        {

        }

    }
}